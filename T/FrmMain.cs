using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T
{
    public partial class FrmMain : Form
    {

        #region 数据区域
        private List<string> listCombobox = new List<string>();
        private int WheelHeight = 0;
        private int ListHeight = 0;
        private bool IsFirst = false;
        #endregion


        public FrmMain()
        {
            InitializeComponent();

            //打开地铁线路图
            metroGraphView1.OpenFromFile(Application.StartupPath + "\\MetroGraph.xml");

            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                        ControlStyles.ResizeRedraw |
                        ControlStyles.AllPaintingInWmPaint, true);

        }

        #region 方法区域
        /// <summary>
        /// 重绘button组件
        /// </summary>
        /// <param name="rectangle">目标区域</param>
        /// <param name="g">目标对象</param>
        /// <param name="_radius">圆角半径</param>
        /// <param name="cusp"></param>
        /// <param name="begin_color">渐变色-起始</param>
        /// <param name="end_color">渐变色-结束</param>
        /// <param name="Pos">按钮方向</param>
        public void Draw(Rectangle rectangle, Graphics g, int _radius, bool cusp, Color begin_color, Color end_color)
        {
            int span = 4;
            //抗锯齿
            g.SmoothingMode = SmoothingMode.AntiAlias;
            //渐变填充
            LinearGradientBrush myLinearGradientBrush = new LinearGradientBrush(rectangle, begin_color, end_color, LinearGradientMode.Vertical);
            //画尖角
            if (cusp)
            {
                span = 10;
                PointF p1 = new PointF(rectangle.Width - 12, rectangle.Y + 10);
                PointF p2 = new PointF(rectangle.Width - 12, rectangle.Y + 30);
                PointF p3 = new PointF(rectangle.Width, rectangle.Y + 20);
                PointF[] ptsArray = { p1, p2, p3 };
                g.FillPolygon(myLinearGradientBrush, ptsArray);
            }
            //填充
            g.FillPath(myLinearGradientBrush, DrawRoundRect(rectangle.X, rectangle.Y, rectangle.Width - span, rectangle.Height - 1, _radius));

        }

        /// <summary>
        /// 绘制圆角
        /// </summary>
        /// <param name="x">坐标</param>
        /// <param name="y">坐标</param>
        /// <param name="width">宽</param>
        /// <param name="height">高</param>
        /// <param name="radius">圆角半径</param>
        /// <returns></returns>
        public static GraphicsPath DrawRoundRect(int x, int y, int width, int height, int radius)
        {
            //四边圆角
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(x, y, radius, radius, 180, 90);
            gp.AddArc(width - radius, y, radius, radius, 270, 90);
            gp.AddArc(width - radius, height - radius, radius, radius, 0, 90);
            gp.AddArc(x, height - radius, radius, radius, 90, 90);
            gp.CloseAllFigures();
            return gp;
        }

        public void selectCombobox(ComboBox cb, List<string> listOnit)
        {
            //输入key之后返回的关键词
            List<string> listNew = new List<string>();
            //清空combobox
            cb.Items.Clear();
            //清空listNew
            listNew.Clear();
            //遍历全部备查数据
            foreach (var item in listOnit)
            {
                if (item.Contains(cb.Text))
                {
                    //符合，插入ListNew
                    listNew.Add(item);
                }
            }
            //combobox添加已经查询到的关键字
            cb.Items.AddRange(listNew.ToArray());
            //设置光标位置，否则光标位置始终保持在第一列，造成输入关键词的倒序排列
            cb.SelectionStart = cb.Text.Length;
            //保持鼠标指针原来状态，有时鼠标指针会被下拉框覆盖，所以要进行一次设置
            Cursor = Cursors.Default;
            //自动弹出下拉框
            cb.DroppedDown = true;
        }
        #endregion


        #region 事件区域
        private void FrmMain_Load(object sender, EventArgs e)
        {
            foreach (var item in metroGraphView1.Graph.Nodes)
                listCombobox.Add(item.Name.ToString());
        }

        private void metroGraphView1_BackColorChanged(object sender, EventArgs e)
        {

            if (metroGraphView1.CurPath.Links.Count > 0)
            {
                CobStart.Text = metroGraphView1.StartNode.Name.ToString();
                CobEnd.Text = metroGraphView1.EndNode.Name.ToString();
                LabNon.Text = "1";

            }
            else
            {
                CobEnd.Text = "";
                CobStart.Text = "";
                PicBoxList.Visible = false;
                BtnAdd.Visible = true;
                BtnMetroHelp.Visible = true;
                BtnSave.Visible = true;
                IsFirst = false;
                ListHeight = 0;
                WheelHeight = 0;
                //PicBoxList.Invalidate();
                return;

            }
        }

        private void LabNon_TextChanged(object sender, EventArgs e)
        {
            PicBoxList.Visible = true;
            BtnAdd.Visible = false;
            BtnMetroHelp.Visible = false;
            BtnSave.Visible = false;
            LabNon.Text = "0";
            PicBoxList.Invalidate();
        }

        private void PicBoxList_Paint(object sender, PaintEventArgs e)
        {
            int ListBox_x = 25;
            int ListBox_y = 50;
            int ListBox_width = 250;
            
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            
            //绘制路线站点名称
            int y = ListBox_y + WheelHeight;
            int count = 0;
            MetroLine preLine = null;
            MetroLine nexLine = null;

            Point preP = new Point(0, 0);
            Point nexP = new Point(0, 0);
            
            //绘制界面
            Draw(new Rectangle(60, y - 30, 200, 50), g, 18, false, Color.Wheat, Color.Wheat);
            g.DrawString("换乘路线", new Font("微软雅黑", 10, FontStyle.Bold), Brushes.Black, 100, y - 25);

            foreach (var link in metroGraphView1.CurPath.Links)
            {
                count++;
                if (link.From.Name == "2" || link.From.Name == "1" )
                    continue;
                var sz = g.MeasureString(link.From.Name, this.Font);

                if (link.From.Name == "3" && metroGraphView1.EndNode.Name.ToString() != link.To.Name.ToString())
                    continue;

                if (link.From.Name == "3" && metroGraphView1.EndNode.Name.ToString() == link.To.Name.ToString())
                {
                    y += 25;
                    g.FillRectangle(new SolidBrush(Color.FromArgb(144, 183, 213)), ListBox_x + 10, y, ListBox_width - 20, 25);
                    g.DrawEllipse(new Pen(link.Line.Color, 5), ListBox_x - 5, y + 8, 8, 8);
                    g.DrawString(link.To.Name, new Font("微软雅黑", 10, FontStyle.Bold), Brushes.Black, ListBox_x + 10, y - sz.Height / 2 + 10);
                    nexP = new Point(ListBox_x - 1, y + 8);
                    g.DrawLine(new Pen(link.Line.Color, 3), preP, nexP);
                    continue;
                }

                if (count % 2 == 1)
                    preLine = link.Line;
                else if (count % 2 == 0)
                    nexLine = link.Line;
                
                if (preLine != nexLine)
                {
                    y += 25;
                    g.FillRectangle(new SolidBrush(Color.FromArgb(144, 183, 213)), ListBox_x + 10, y, ListBox_width - 20, 25);
                    g.DrawEllipse(new Pen(link.Line.Color, 5), ListBox_x - 5, y + 8, 8, 8);
                    g.DrawString(link.From.Name, new Font("微软雅黑", 10, FontStyle.Bold), Brushes.Black, ListBox_x+10, y - sz.Height / 2 + 10);
                }
                else
                {
                    y += 20;
                    g.DrawString(link.From.Name, new Font("微软雅黑", 8, FontStyle.Bold), Brushes.Black, ListBox_x+10, y - sz.Height / 2 + 10);
                }

                if (count % 2 == 1)
                    preP = new Point(ListBox_x-1, y + 8);
                else if (count % 2 == 0)
                    nexP = new Point(ListBox_x-1, y + 8);

                if (nexP.Y!=0)
                    g.DrawLine(new Pen(preLine.Color, 3), preP, nexP);

                if (count == metroGraphView1.CurPath.Links.Count)
                {
                    y += 25;
                    g.FillRectangle(new SolidBrush(Color.FromArgb(144, 183, 213)), ListBox_x + 10, y, ListBox_width - 20, 25);
                    g.DrawEllipse(new Pen(link.Line.Color,5), ListBox_x - 5, y + 8, 8, 8);
                    g.DrawString(link.To.Name, new Font("微软雅黑", 10, FontStyle.Bold), Brushes.Black, ListBox_x+10, y - sz.Height / 2 + 10);
                    nexP = new Point(ListBox_x-1, y + 8);
                    g.DrawLine(new Pen(link.Line.Color, 3), preP, nexP);
                }
            }

            if (PicBoxList.Visible == true && !IsFirst)
            {
                ListHeight = y - ListBox_y;
                IsFirst = true;
            }

        }

        private void PicBoxList_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            WheelHeight += (e.Delta > 0 ? 20 : -20);

            if (WheelHeight < 300 - ListHeight)
                WheelHeight = 300 - ListHeight;
            if (WheelHeight > 0)
                WheelHeight = 0;
            
            Invalidate();
        }

        /// <summary>
        /// Button相关事件
        /// </summary>
        private void BtnAddNode_Click(object sender, EventArgs e)
        {
            this.PnlAddNode.Visible = true;
            this.BtnAdd.Visible = false;
            this.BtnSave.Visible = false;
            this.BtnMetroHelp.Visible = false;
        }

        private void BtnAddNodeC_Click(object sender, EventArgs e)
        {
            try
            {
                bool IsDouLine1 = false ;
                bool IsDouLine2 = false ;

                MetroNode NewNode = new MetroNode();
                MetroNode PreNode = new MetroNode();
                MetroNode NexNode = new MetroNode();

                String Prename = (CobPreNode.Text.ToString() == "海伦路" && CobNexNode.Text.ToString() == "宝山路") || (CobPreNode.Text.ToString() == "宝山路" && CobNexNode.Text.ToString() == "海伦路") ? "3" : CobPreNode.Text.ToString();
                String Nexname = (CobPreNode.Text.ToString() == "海伦路" && CobNexNode.Text.ToString() == "宝山路") || (CobPreNode.Text.ToString() == "宝山路" && CobNexNode.Text.ToString() == "海伦路") ? "2" : CobNexNode.Text.ToString();

                foreach (var node in metroGraphView1.Graph.Nodes)
                {
                    if (node.Name == Prename)
                        PreNode = node;

                    if (node.Name == Nexname)
                        NexNode = node;
                }

                NewNode.Name = this.TxtNodeName.Text.ToString();
                NewNode.X = (CobPreNode.Text.ToString() == "海伦路" && CobNexNode.Text.ToString() == "宝山路") || (CobPreNode.Text.ToString() == "宝山路" && CobNexNode.Text.ToString() == "海伦路") ? 2033 : int.Parse(this.TxtNodeX.Text.ToString());
                NewNode.Y = (CobPreNode.Text.ToString() == "海伦路" && CobNexNode.Text.ToString() == "宝山路") || (CobPreNode.Text.ToString() == "宝山路" && CobNexNode.Text.ToString() == "海伦路") ? 750 : int.Parse(this.TxtNodeY.Text.ToString());

                if ((Math.Abs(NewNode.X - PreNode.X) > 200 || Math.Abs(NewNode.Y - PreNode.Y) > 200 || Math.Abs(NewNode.X - NexNode.X) > 200 || Math.Abs(NewNode.Y - NexNode.Y) > 200)&&(PreNode.Name!=""&&NexNode.Name!=""))
                {
                    MessageBox.Show("距离太远了哦，请重新设定坐标(´▽`ʃ♡ƪ)");
                    this.TxtNodeX.Text = "";
                    this.TxtNodeY.Text = "";
                    return;
                }


                for (int i = 0; i < PreNode.Links.Count; i++)
                    if (PreNode.Links[i].Flag == 1 && PreNode.Links.Count > 3)
                        IsDouLine1 = true;
                for (int i = 0; i < NexNode.Links.Count; i++)
                    if (NexNode.Links[i].Flag == 1 && NexNode.Links.Count > 3)
                        IsDouLine2 = true;

                if (!IsDouLine2 || !IsDouLine1)
                {
                    MetroLine NewLine = new MetroLine();
                    
                    foreach (var line in metroGraphView1.Graph.Lines)
                    {
                        if (line.Name == CobNodeLine.Text.ToString())
                            NewLine = line;
                    }
                    
                    if (!((CobPreNode.Text == "" || CobPreNode.Text == null) && NexNode.Links.Count <= 1))
                    {
                        MetroLink NewLink = new MetroLink(NewLine, NewNode, PreNode);
                        NewLink.Weight = 3;
                        NewNode.Links.Add(NewLink);
                        NewLink.Flag = 0;
                    }
                    if (!((CobNexNode.Text == "" || CobNexNode.Text == null) && PreNode.Links.Count <= 1))
                    {
                        MetroLink NewLink = new MetroLink(NewLine, NewNode, NexNode);
                        NewLink.Flag = 0;
                        NewLink.Weight = 3;
                        NewNode.Links.Add(NewLink);
                    }
                    

                    if (!((CobPreNode.Text == "" || CobPreNode.Text == null) && NexNode.Links.Count <= 1))
                        for (int i = 0; i < PreNode.Links.Count; i++)
                            if (PreNode.Links[i].To.Name == NexNode.Name)
                                PreNode.Links.RemoveAt(i);

                    PreNode.Links.Add(new MetroLink(NewLine, PreNode, NewNode));

                    if (!((CobNexNode.Text == "" || CobNexNode.Text == null) && PreNode.Links.Count <= 1))
                        for (int i = 0; i < NexNode.Links.Count; i++)
                            if (NexNode.Links[i].To.Name == PreNode.Name)
                                NexNode.Links.RemoveAt(i);

                    NexNode.Links.Add(new MetroLink(NewLine, NexNode, NewNode));
                    metroGraphView1.Graph.Nodes.Add(NewNode);
                }
                else
                {
                    for (int i = 0; i < PreNode.Links.Count; i++)
                        if (PreNode.Links[i].To.Name == NexNode.Name)
                        {
                            MetroLine NewLine = new MetroLine();
                            
                            NewLine = PreNode.Links[i].Line;
                            MetroLink NewLink = new MetroLink(NewLine, PreNode, NewNode);
                            NewLink.Flag = PreNode.Links[i].Flag;
                            MetroLink SNewLink = new MetroLink(NewLine, NewNode, NexNode);
                            SNewLink.Flag = PreNode.Links[i].Flag;
                            SNewLink.Weight = 3;
                            NewNode.Links.Add(SNewLink);
                            PreNode.Links.RemoveAt(i);
                            PreNode.Links.Add(NewLink);
                            
                        }

                    for (int i = 0; i < NexNode.Links.Count; i++)
                        if (NexNode.Links[i].To.Name == PreNode.Name)
                        {
                            MetroLine NewLine = new MetroLine();

                            NewLine = NexNode.Links[i].Line;
                            MetroLink NewLink = new MetroLink(NewLine, NexNode, NewNode);
                            NewLink.Flag = NexNode.Links[i].Flag;
                            MetroLink SNewLink = new MetroLink(NewLine, NewNode, PreNode);
                            SNewLink.Flag= NexNode.Links[i].Flag;
                            SNewLink.Weight = 3;
                            NewNode.Links.Add(SNewLink);
                            NexNode.Links.RemoveAt(i);
                            NexNode.Links.Add(NewLink);
                            
                        }

                    metroGraphView1.Graph.Nodes.Add(NewNode);
                }

                //metroGraphView1.SaveToFile(Application.StartupPath + "\\MetroGraph.xml");
                metroGraphView1.Invalidate();

                this.CobPreNode.Text = "";
                this.CobNexNode.Text = "";
                this.TxtNodeName.Text = "";
                this.TxtNodeX.Text = "";
                this.TxtNodeY.Text = "";
                this.TxtLineName.Text = "";
                this.CobNodeLine.Text = "";
                this.colorDialog1.Reset();
                this.LabNexXY.Text = "";
                this.LabPreXY.Text = "";
            }
            catch
            {
                MessageBox.Show("请检查是否有误哦(✿◕‿◕✿)");
                return;
            }
            
            this.PnlAddNode.Visible = false;
            this.BtnMetroHelp.Visible = true;
            this.BtnAdd.Visible = true;
            this.BtnSave.Visible = true;
        }
        
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                metroGraphView1.FindPath(CobStart.Text.ToString(), CobEnd.Text.ToString());
            }
            catch
            {
                return;
            }
        }

        private void BtnAddLine1_Click(object sender, EventArgs e)
        {
            this.PnlAddNode.Visible = false;
            this.PnlAddLine.Visible = true;
        }

        private void BtnAddNode1_Click(object sender, EventArgs e)
        {
            this.PnlAddLine.Visible = false;
            this.PnlAddNode.Visible = true;
        }

        private void BtnAddLine2_Click(object sender, EventArgs e)
        {
            this.PnlAddNode.Visible = false;
            this.PnlAddLine.Visible = true;
        }

        private void BtnAddNode2_Click(object sender, EventArgs e)
        {
            this.PnlAddLine.Visible = false;
            this.PnlAddNode.Visible = true;
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void BtnAddNodeX_Click(object sender, EventArgs e)
        {
            this.BtnAdd.Visible = true;
            this.PnlAddLine.Visible = false;
            this.PnlAddNode.Visible = false;
            this.BtnMetroHelp.Visible = true;
            this.BtnSave.Visible = true;

            this.CobPreNode.Text = "";
            this.CobNexNode.Text = "";
            this.TxtNodeName.Text = "";
            this.TxtNodeX.Text = "";
            this.TxtNodeY.Text = "";
            this.TxtLineName.Text = "";
            this.CobNodeLine.Text = "";
            this.colorDialog1.Reset();
            this.LabNexXY.Text = "";
            this.LabPreXY.Text = "";
        }

        private void BtnAddLineC_Click(object sender, EventArgs e)
        {
            MetroLine NewLine = new MetroLine();

            foreach (var line in metroGraphView1.Graph.Lines)
            {
                if (this.colorDialog1.Color == line.Color || this.colorDialog1.Color == Color.White)
                {
                    MessageBox.Show("该路线颜色已经存在，请重新选取哦ฅʕ•̫͡•ʔฅ");
                    return;
                }

                if (this.TxtLineName.Text.ToString() == line.Name.ToString())
                {
                    MessageBox.Show("该路线名已经存在，请重新命名哦ฅʕ•̫͡•ʔฅ");
                    return;
                }
            }

            NewLine.Name = this.TxtLineName.Text.ToString();
            NewLine.Color = this.colorDialog1.Color;

            metroGraphView1.Graph.Lines.Add(NewLine);
            CobNodeLine.Items.Add(NewLine.Name);

            //metroGraphView1.SaveToFile(Application.StartupPath + "\\MetroGraph.xml");
            
            MessageBox.Show("添加成功\\(0^◇^0)/");

            this.BtnAdd.Visible = true;
            this.BtnMetroHelp.Visible = true;
            this.BtnSave.Visible = true;
            this.PnlAddLine.Visible = false;
            this.PnlAddNode.Visible = false;

            metroGraphView1.Invalidate();

            this.CobPreNode.Text = "";
            this.CobNexNode.Text = "";
            this.TxtNodeName.Text = "";
            this.TxtNodeX.Text = "";
            this.TxtNodeY.Text = "";
            this.TxtLineName.Text = "";
            this.CobNodeLine.Text = "";
            this.colorDialog1.Reset();
            this.LabNexXY.Text = "";
            this.LabPreXY.Text = "";
        }

        private void BtnAddLineX_Click(object sender, EventArgs e)
        {
            this.BtnAdd.Visible = true;
            this.BtnSave.Visible = true;
            this.BtnMetroHelp.Visible = true;
            this.PnlAddLine.Visible = false;
            this.PnlAddNode.Visible = false;

            this.CobPreNode.Text = "";
            this.CobNexNode.Text = "";
            this.TxtNodeName.Text = "";
            this.TxtNodeX.Text = "";
            this.TxtNodeY.Text = "";
            this.TxtLineName.Text = "";
            this.CobNodeLine.Text = "";
            this.colorDialog1.Reset();
            this.LabNexXY.Text = "";
            this.LabPreXY.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult diagorel = MessageBox.Show("是否将该地铁线路信息保存到本地（添加站点或线路）\n极其不推荐(╯‵□′)╯炸弹！•••*～●", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //string strMenuXml = Directory.GetCurrentDirectory() + "\\MetroGraph.xml";
            switch (diagorel)
            {
                case DialogResult.OK:
                    metroGraphView1.SaveToFile(Application.StartupPath + "\\MetroGraph.xml");
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void BtnMetroHelp_Click(object sender, EventArgs e)
        {
            MetroHelp H = new MetroHelp();
            H.Show();
        }

        private void BtnSearch_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 18, false, Color.FromArgb(255, 144, 183, 213), Color.FromArgb(255, 144, 183, 213));
            base.OnPaint(e);
            Graphics g = e.Graphics;
            var startNodeImage = Properties.Resources.Search;
            g.DrawImage(startNodeImage, 9, 9);

        }

        private void BtnAddNode_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 18, false, Color.FromArgb(255, 144, 183, 213), Color.FromArgb(255, 144, 183, 213));
            base.OnPaint(e);

            Graphics g = e.Graphics;
            var startNodeImage = Properties.Resources.Set;
            g.DrawImage(startNodeImage, 11, 11);
        }

        private void BtnSave_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 18, false, Color.FromArgb(255, 144, 183, 213), Color.FromArgb(255, 144, 183, 213));
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.DrawString("Save", new Font("微软雅黑", 12, FontStyle.Bold), new SolidBrush(Color.White), new PointF(0, 10));
        }

        private void BtnMetroHelp_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 18, false, Color.FromArgb(255, 144, 183, 213), Color.FromArgb(255, 144, 183, 213));
            base.OnPaint(e);

            Graphics g = e.Graphics;
            var startNodeImage = Properties.Resources.Help;
            g.DrawImage(startNodeImage, 8, 8);
        }

        private void BtnAddLine2_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 18, false, Color.FromArgb(255, 144, 183, 213), Color.FromArgb(255, 144, 183, 213));
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.DrawString("Add Line", new Font("微软雅黑", 9, FontStyle.Bold), new SolidBrush(Color.White), new PointF(60, 3));
        }

        private void BtnAddNode2_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 18, false, Color.FromArgb(255, 144, 183, 213), Color.FromArgb(255, 144, 183, 213));
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.DrawString("Add Node", new Font("微软雅黑", 9, FontStyle.Bold), new SolidBrush(Color.White), new PointF(60, 3));
        }

        private void BtnAddNode1_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 18, false, Color.FromArgb(255, 144, 183, 213), Color.FromArgb(255, 144, 183, 213));
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.DrawString("Add Node", new Font("微软雅黑", 9, FontStyle.Bold), new SolidBrush(Color.White), new PointF(60, 3));
        }

        private void BtnAddLine1_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 18, false, Color.FromArgb(255, 144, 183, 213), Color.FromArgb(255, 144, 183, 213));
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.DrawString("Add Line", new Font("微软雅黑", 9, FontStyle.Bold), new SolidBrush(Color.White), new PointF(60, 3));
        }

        /// <summary>
        /// ComBox相关事件
        /// </summary>
        private void CobStart_TextUpdate(object sender, EventArgs e)
        {
            listCombobox.Clear();
            foreach (var item in metroGraphView1.Graph.Nodes)
                listCombobox.Add(item.Name.ToString());
            selectCombobox(this.CobStart, listCombobox);
        }

        private void CobEnd_TextUpdate(object sender, EventArgs e)
        {
            listCombobox.Clear();
            foreach (var item in metroGraphView1.Graph.Nodes)
                listCombobox.Add(item.Name.ToString());
            selectCombobox(this.CobEnd, listCombobox);
        }

        private void CobPreNode_TextUpdate(object sender, EventArgs e)
        {
            listCombobox.Clear();
            foreach (var item in metroGraphView1.Graph.Nodes)
                listCombobox.Add(item.Name.ToString());
            selectCombobox(this.CobPreNode, listCombobox);
        }

        private void CobNexNode_TextUpdate(object sender, EventArgs e)
        {
            listCombobox.Clear();
            foreach (var item in metroGraphView1.Graph.Nodes)
                listCombobox.Add(item.Name.ToString());
            selectCombobox(this.CobNexNode, listCombobox);
        }
        
        private void CobPreNode_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (var item in metroGraphView1.Graph.Nodes)
                if (item.Name == CobPreNode.Text)
                {
                    this.LabPreXY.Text = item.X.ToString() + "," + item.Y.ToString();
                    break;
                }
        }

        private void CobNexNode_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (var item in metroGraphView1.Graph.Nodes)
                if (item.Name == CobNexNode.Text)
                {
                    this.LabNexXY.Text = item.X.ToString() + "," + item.Y.ToString();
                    break;
                }
        }

        private void CobEnd_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                metroGraphView1.FindPath(CobStart.Text.ToString(), CobEnd.Text.ToString());

            }
            catch
            {
                return;
            }
        }






        #endregion

        

        
    }
}
