using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T
{
    public partial class StackSort : Form
    {
        public StackSort()
        {
            InitializeComponent();
        }

        #region 数据区域
        /// <summary>
        /// DATA
        /// </summary>
        private ArrayList SourceArray = new ArrayList();    //存储用户输入的数据
        private ArrayList NonSortArray = new ArrayList();   //待排序
        private ArrayList SortedArray = new ArrayList();    //已排序
        private bool IsDraw = false;
        #endregion
        

        #region 方法区域
        /// <summary>
        /// 绘制树状图
        /// </summary>
        /// <param name="a">目标数组</param>
        void UserDrawTree(int[] a)
        {
            Graphics g = this.panel3.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//使绘图质量最高，即消除锯齿
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            //清空原数据
            g.Clear(this.BackColor);

            Pen p = new Pen(Brushes.Purple,2);
            //颜色
            Brush brush = new SolidBrush(Color.FromArgb(0, 0, 0));
            //选择字体、字号、风格
            Font font = new Font("微软雅黑", 12, FontStyle.Regular);

            int N = a.Length;
            int Deep = (int)Math.Log(N, 2) + 1;
            int LengthLstLayer = (int)Math.Pow(2, Deep-1);

            int MIDDLE_W = 415;
            int MIDDLE_H = 180;
            int LAYER_W = 50;
            int LAYER_H = 50;
            int LEFT = MIDDLE_W - 25 * LengthLstLayer;

            int[] Positionx = new int[N];

            //绘制根节点
            if (a.Length < 1) return;
            g.DrawString(a[0].ToString(), font, brush, MIDDLE_W, MIDDLE_H);
            Positionx[0] = MIDDLE_W + 8;

            for (int i = 1; i < N; i++)
            {
                int Co = (int)(Math.Pow(2, Deep - Math.Floor(Math.Log(i + 1, 2)) - 1));
                int LineF = (int)(Math.Pow(2, Math.Floor(Math.Log(i + 1, 2))));

                g.DrawString(a[i].ToString(), font, brush, LEFT + 25 * Co + LAYER_W * Co * (i + 1 - LineF), MIDDLE_H + LAYER_H * (int)Math.Floor(Math.Log(i + 1, 2)));
                Positionx[i] = LEFT + 25 * Co + LAYER_W * Co * (i + 1 - LineF) + 8;
            }

            //绘制直线
            int CountLine = 0;
            for (int i = 0; i < N; i++)
            {
                if (a.Length < 2) break;

                Point P1 = new Point(Positionx[i], MIDDLE_H + LAYER_H * (int)Math.Floor(Math.Log(i + 1, 2))+18);
                Point P2 = new Point(Positionx[i*2+1], MIDDLE_H + LAYER_H * (int)Math.Floor(Math.Log(i*2+1 + 1, 2)));
                
                g.DrawLine(p, P1, P2);
                CountLine++;
                if (CountLine == N - 1) break;

                Point P3 = new Point(Positionx[i * 2 + 1 + 1], MIDDLE_H + LAYER_H * (int)Math.Floor(Math.Log(i * 2 + 1 + 1, 2)));
                g.DrawLine(p, P1, P3);
                CountLine++;
                if (CountLine == N - 1) break;
            }
        }

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

        /// <summary>
        /// button事件进行绘制
        /// </summary>
        /// <param name="permission">是否进行绘制</param>
        void UserDrawLine(bool permission)
        {
            if(permission)
            {
                Graphics g = this.CreateGraphics();
                //清空原数据
                g.Clear(this.BackColor);
                
                //颜色
                Brush brush = new SolidBrush(Color.FromArgb(0, 0, 0));
                //选择字体、字号、风格
                Font font = new Font("微软雅黑", 12, FontStyle.Regular );


                //获取textbox中的数组
                string[] strN = textBox1.Text.Split(' ');
                //整形数组
                int[] values = new int[strN.Length];
                //初始化整型数组

                try
                {
                    for (int i = 0; i < strN.Length; i++)
                        values[i] = int.Parse(strN[i]);
                }
                catch
                {
                    MessageBox.Show("该数值超出范围了哟(っ´Ι`)っ");
                    this.textBox1.Text = "";
                    IsDraw = false;
                    return;
                }

                //堆排序调用
                values = MinHeapSort(values);

                // 将数组构建为最小堆  
                /*BulidMinHeap(a);

                int aLenght = a.Length;
                int heapSize = aLenght;
                int[] sorttedArray = new int[a.Length];
                for (int i = 0; i < aLenght; i++)
                {
                    // 将根节点的最小值取出  
                    sorttedArray[i] = a[0];
                    a[0] = a[heapSize - 1];

                    MinHeapify(a, 0, heapSize--);
                }*/

                UserDrawTree(values);

                
                //结果输出
                for (int i = 0; i < values.Length; i++)
                    g.DrawString(values[i].ToString(), font, brush, 150 + 30 * i, 500);
            }
        }
        
        /// <summary>
        ///堆排序过程
        /// <summary>
        public static int[] MinHeapSort(int[] a)
        {
            // 将数组构建为最小堆  
            BulidMinHeap(a);

            int aLenght = a.Length;
            int heapSize = aLenght;
            int[] sorttedArray = new int[a.Length];
            for (int i = 0; i < aLenght; i++)
            {
                // 将根节点的最小值取出  
                sorttedArray[i] = a[0];
                a[0] = a[heapSize - 1];

                MinHeapify(a, 0, heapSize--);
            }

            return sorttedArray;
        }

        /// <summary>  
        /// 将数组构建为最小堆  
        /// </summary>  
        public static void BulidMinHeap(int[] a)
        {
            for (int i = a.Length / 2 - 1; i >= 0; i--)
            {
                MinHeapify(a, i, a.Length);
            }
        }

        /// <summary>  
        /// 调整二叉堆,即将以i为根节点的二叉树调整为最小堆  
        /// </summary>  
        public static void MinHeapify(int[] a, int i, int heapSize)
        {
            int left = i * 2 + 1;// 左儿子的索引  
            int right = i * 2 + 2;// 右儿子的索引  
            int mivValueIndex = i;// 保存最小值的索引  

            if (left < heapSize && a[i] > a[left])
            {
                // 左儿子小于当前节点,则记录做儿子的索引,作为最小值索引  
                mivValueIndex = left;
            }
            if (right < heapSize && a[mivValueIndex] > a[right])
            {
                // 右儿子小于当前节点,则记录做儿子的索引,作为最小值索引  
                mivValueIndex = right;
            }

            if (mivValueIndex != i)
            {
                // 交换根和子节点值  
                int temp = a[i];
                a[i] = a[mivValueIndex];
                a[mivValueIndex] = temp;

                // 递归处理子树  
                MinHeapify(a, mivValueIndex, heapSize);
            }
        }
        #endregion
        

        #region 事件区域
        /// <summary>
        ///用于判定textbox中的输入是否符合要求
        /// <summary>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //允许输入数字、小数点、删除键和负号  
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != (char)('.') && e.KeyChar != (char)('-') && e.KeyChar != 13)
            {
                MessageBox.Show("请输入正确的数字哟(っ´Ι`)っ");
                this.textBox1.Text = "";
                e.Handled = true;
            }
            if (e.KeyChar == (char)('-'))
            {
                string strText = textBox1.Text;
                if (!(strText.EndsWith(" ") || strText == ""))
                {
                    MessageBox.Show("请输入正确的数字");
                    this.textBox1.Text = "";
                    e.Handled = true;
                }
            }
            //不支持小数
            if (e.KeyChar == (char)('.'))
            {
                MessageBox.Show("仅允许输入整数(oﾟvﾟ)ノ");
                this.textBox1.Text = "";
                e.Handled = true;
            }

        }

        /// <summary>
        ///其他判定
        /// <summary>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            IsDraw = false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)   //  if (e.KeyValue == 13) 判断是回车键
            {
                if (textBox1.Text.EndsWith(" "))
                {
                    MessageBox.Show("该数字序列不能以空格结束(●ˇ∀ˇ●)");
                    this.textBox1.Text = "";
                    e.Handled = true;
                }
                else
                {
                    IsDraw = true;

                    try
                    {
                        SourceArray.Add(int.Parse(textBox1.Text.ToString()));
                    }
                    catch
                    {
                        MessageBox.Show("  你输入了数字么\n   ━┳━　━┳━");
                        this.textBox1.Text = "";
                        return;
                    }

                    int[] a = new int[SourceArray.Count];

                    for (int i = 0; i < SourceArray.Count; i++)
                        a[i] = int.Parse(SourceArray[i].ToString());

                    UserDrawTree(a);

                    this.textBox1.Clear();
                    this.textBox1.Focus();
                }
            }
        }

        /// <summary>
        /// 重绘事件
        /// </summary>
        private void Next_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 18, false, Color.FromArgb(255, 144, 183, 213), Color.FromArgb(255, 144, 183, 213));
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.DrawString("Next", new Font("微软雅黑", 9, FontStyle.Bold), new SolidBrush(Color.White), new PointF(10, 15));
        }

        private void Prev_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 18, false, Color.FromArgb(255, 144, 183, 213), Color.FromArgb(255, 144, 183, 213));
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.DrawString("Prev", new Font("微软雅黑", 9, FontStyle.Bold), new SolidBrush(Color.White), new PointF(10, 15));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 18, false, Color.FromArgb(255, 144, 183, 213), Color.FromArgb(255, 144, 183, 213));
            base.OnPaint(e);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (IsDraw)
            {
                UserDrawLine(IsDraw);
            }
        }

        private void StackSort_Activated(object sender, EventArgs e)
        {
            this.textBox1.Focus();
        }

        private void SubOne_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 15, false, Color.FromArgb(255, 144, 183, 213), Color.FromArgb(255, 144, 183, 213));
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.DrawString("-", new Font("微软雅黑", 12, FontStyle.Bold), new SolidBrush(Color.White), new PointF(3, -2));
        }

        private void AddOne_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 15, false, Color.FromArgb(255, 144, 183, 213), Color.FromArgb(255, 144, 183, 213));
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.DrawString("+", new Font("微软雅黑", 12, FontStyle.Bold), new SolidBrush(Color.White), new PointF(0, -2));
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 18, false, Color.FromArgb(255, 144, 183, 213), Color.FromArgb(255, 144, 183, 213));
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.DrawString("Start", new Font("微软雅黑", 10, FontStyle.Bold), new SolidBrush(Color.FromArgb(255, 22, 86, 141)), new PointF(10, 5));
        }

        private void ActionStep_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 18, false, Color.FromArgb(255, 144, 183, 213), Color.FromArgb(255, 144, 183, 213));
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.DrawString("Step", new Font("微软雅黑", 9, FontStyle.Bold), new SolidBrush(Color.White), new PointF(11, 3));
        }

        private void ActionALL_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 18, false, Color.FromArgb(255, 144, 183, 213), Color.FromArgb(255, 144, 183, 213));
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.DrawString("All", new Font("微软雅黑", 9, FontStyle.Bold), new SolidBrush(Color.White), new PointF(16, 3));
        }

        private void RESTART_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 18, false, Color.FromArgb(255, 144, 183, 213), Color.FromArgb(255, 144, 183, 213));
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.DrawString("Restart", new Font("微软雅黑", 9, FontStyle.Bold), new SolidBrush(Color.White), new PointF(2, 14));
        }

        private void StackExit_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 6, false, Color.FromArgb(255, 117, 26, 90), Color.FromArgb(255, 117, 26, 90));
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.DrawString("Exit", new Font("微软雅黑", 9, FontStyle.Bold), new SolidBrush(Color.White), new PointF(13, 5));
        }

        private void BtnHelp_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 6, false, Color.FromArgb(255, 117, 26, 90), Color.FromArgb(255, 117, 26, 90));
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.DrawString("Help", new Font("微软雅黑", 9, FontStyle.Bold), new SolidBrush(Color.White), new PointF(11, 5));
        }

        private void BtnStackRst_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 6, false, Color.FromArgb(255, 117, 26, 90), Color.FromArgb(255, 117, 26, 90));
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.DrawString("Reset", new Font("微软雅黑", 9, FontStyle.Bold), new SolidBrush(Color.White), new PointF(9, 5));
        }

        /// <summary>
        /// 鼠标移动事件
        /// </summary>
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        /// <summary>
        /// 鼠标点击事件
        /// </summary>
        private void AddOne_Click(object sender, EventArgs e)
        {
            try
            {
                SourceArray.Add(int.Parse(textBox1.Text.ToString()));
            }
            catch
            {
                MessageBox.Show("  你输入了数字么\n   ━┳━　━┳━");
                this.textBox1.Text = "";
                return;
            }

            int[] a = new int[SourceArray.Count];

            for (int i = 0; i < SourceArray.Count; i++)
                a[i] = int.Parse(SourceArray[i].ToString());

            UserDrawTree(a);

            this.textBox1.Clear();
            this.textBox1.Focus();
        }

        private void SubOne_Click(object sender, EventArgs e)
        {
            if (SourceArray.Count < 1)
            {
                MessageBox.Show("  你输入了数字么\n   …(⊙_⊙;)…");
                return;
            }
            SourceArray.RemoveAt(SourceArray.Count-1);

            int[] a = new int[SourceArray.Count];

            for (int i = 0; i < SourceArray.Count; i++)
                a[i] = int.Parse(SourceArray[i].ToString());

            UserDrawTree(a);
        }

        private void ActionStep_Click(object sender, EventArgs e)
        {
            this.Next.Visible = true;
            this.ActionALL.Visible = false;
            this.ActionStep.Visible = false;

            if (SourceArray.Count < 1) return;

            SortedArray.Clear();
            NonSortArray.Clear();
            
            int[] a = new int[SourceArray.Count];

            for (int i = 0; i < SourceArray.Count; i++)
                a[i] = int.Parse(SourceArray[i].ToString());
                
            BulidMinHeap(a);

            for (int i = 0; i < SourceArray.Count; i++)
                NonSortArray.Add(a[i]);

            UserDrawTree(a);
        }
        
        private void ActionALL_Click(object sender, EventArgs e)
        {
            this.Next.Visible = false;
            this.ActionALL.Visible = false;
            this.ActionStep.Visible = false;

            if (SourceArray.Count < 1) return;
            SortedArray.Clear();

            Graphics g = this.panel3.CreateGraphics();
            //颜色
            Brush brush = new SolidBrush(Color.FromArgb(117, 26, 90));
            //选择字体、字号、风格
            Font font = new Font("微软雅黑", 9, FontStyle.Bold);

            int[] a = new int[SourceArray.Count];

            for (int i = 0; i < SourceArray.Count; i++)
                a[i] = int.Parse(SourceArray[i].ToString());

            BulidMinHeap(a);
            
            int aLenght = a.Length;
            int heapSize = aLenght;
            int[] sorttedArray = new int[a.Length];
            for (int i = 0; i < aLenght; i++)
            {
                // 将根节点的最小值取出  
                SortedArray.Add(a[0]);
                sorttedArray[i] = a[0];
                a[0] = a[heapSize - 1];

                MinHeapify(a, 0, heapSize--);

                int[] nonsortArray = new int[heapSize];
                for (int j = 0; j < heapSize; j++)
                    nonsortArray[j] = a[j];

                UserDrawTree(nonsortArray);

                for(int j=0;j<SortedArray.Count;j++)
                    g.DrawString(SortedArray[j].ToString(), font, brush, 150 + 40 * j, 500);

                System.Threading.Thread.Sleep(500);
            }

            this.RESTART.Visible = true;

            g.Clear(BackColor);
            g.DrawString("SourceArray:", font, brush, 60, 250);
            for (int i = 0; i < SourceArray.Count; i++)
                if (150 + 40 * i > this.Width)
                    g.DrawString(SourceArray[i].ToString(), font, brush, 150 + 40 * i - this.Width, 275);
                else
                    g.DrawString(SourceArray[i].ToString(), font, brush, 150 + 40 * i, 250);

            g.DrawString("SortedArray:", font, brush, 60, 350);
            for (int i = 0; i < SortedArray.Count; i++)
                if (150 + 40 * i > this.Width)
                    g.DrawString(SortedArray[i].ToString(), font, brush, 150 + 40 * i - this.Width, 375);
                else
                    g.DrawString(SortedArray[i].ToString(), font, brush, 150 + 40 * i, 350);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SourceArray.Count < 1)
            {
                MessageBox.Show("  你输入了数字么\n   つ﹏⊂");
                return;
            }

            this.button1.Visible = false;
            this.AddOne.Visible = false;
            this.SubOne.Visible = false;
            this.ActionALL.Visible = true;
            this.ActionStep.Visible = true;
        }
        
        private void Next_Click(object sender, EventArgs e)
        {
            Graphics g = this.panel3.CreateGraphics();
            //颜色
            Brush brush = new SolidBrush(Color.FromArgb(117, 26, 90));
            //选择字体、字号、风格
            Font font = new Font("微软雅黑", 9, FontStyle.Bold);

            if (NonSortArray.Count == 0)
            {
                this.Next.Visible = false;
                this.RESTART.Visible = true;
                
                g.Clear(BackColor);
                g.DrawString("SourceArray:", font, brush, 60, 250);
                for (int i = 0; i < SourceArray.Count; i++)
                    if (150 + 40 * i > this.Width)
                        g.DrawString(SourceArray[i].ToString(), font, brush, 150 + 40 * i - this.Width, 275);
                    else
                        g.DrawString(SourceArray[i].ToString(), font, brush, 150 + 40 * i, 250);

                g.DrawString("SortedArray:", font, brush, 60, 350);
                for (int i = 0; i < SortedArray.Count; i++)
                    if (150 + 40 * i > this.Width)
                        g.DrawString(SortedArray[i].ToString(), font, brush, 150 + 40 * i - this.Width, 375);
                    else
                        g.DrawString(SortedArray[i].ToString(), font, brush, 150 + 40 * i, 350);

                return;
            }
            
            SortedArray.Add(NonSortArray[0]);
            NonSortArray[0] = NonSortArray[NonSortArray.Count - 1];
            NonSortArray.RemoveAt(NonSortArray.Count - 1);

            int[] a = new int[NonSortArray.Count];

            for (int i = 0; i < NonSortArray.Count; i++)
                a[i] = int.Parse(NonSortArray[i].ToString());

            MinHeapify(a, 0, NonSortArray.Count);

            for (int i = 0; i < NonSortArray.Count; i++)
                NonSortArray[i] = a[i];

                UserDrawTree(a);

            for (int i = 0; i < SortedArray.Count; i++)
                g.DrawString(SortedArray[i].ToString(), font, brush, 150 + 40 * i, 500);
        }

        private void RESTART_Click(object sender, EventArgs e)
        {
            this.AddOne.Visible = true;
            this.SubOne.Visible = true;
            this.button1.Visible = true;
            this.RESTART.Visible = false;
            this.textBox1.Clear();

            SourceArray.Clear();
            NonSortArray.Clear();
            SortedArray.Clear();

            Graphics g = this.panel3.CreateGraphics();
            g.Clear(this.BackColor);
        }

        private void StackExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            StackSortHelp S = new StackSortHelp();
            S.Show();
        }

        private void BtnStackRst_Click(object sender, EventArgs e)
        {
            this.AddOne.Visible = true;
            this.SubOne.Visible = true;
            this.button1.Visible = true;
            this.RESTART.Visible = false;
            this.textBox1.Clear();

            SourceArray.Clear();
            NonSortArray.Clear();
            SortedArray.Clear();

            Graphics g = this.panel3.CreateGraphics();
            g.Clear(this.BackColor);
        }

        #endregion

        
    }
}
