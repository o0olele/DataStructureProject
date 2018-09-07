using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        

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

        
         private void PnlMetro_Paint(object sender, PaintEventArgs e)
        {
            BufferedGraphicsContext currentContext = BufferedGraphicsManager.Current;

            BufferedGraphics myBuffer = currentContext.Allocate(e.Graphics, e.ClipRectangle);

            Graphics g = myBuffer.Graphics;

            g.Clear(this.BackColor);

            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.FillPath(new SolidBrush(Color.FromArgb(255, 144, 183, 213)), DrawRoundRect(0, 0, 148, 146, 146));

            g.DrawString("上海地铁", new Font("微软雅黑", 9, FontStyle.Bold), new SolidBrush(Color.White), new PointF(50, 66));

            myBuffer.Render(e.Graphics);  //呈现图像至关联的Graphics

            myBuffer.Dispose();
            g.Dispose();
        }

        private void PnlStack_Paint(object sender, PaintEventArgs e)
        {
            BufferedGraphicsContext currentContext = BufferedGraphicsManager.Current;

            BufferedGraphics myBuffer = currentContext.Allocate(e.Graphics, e.ClipRectangle);

            Graphics g = myBuffer.Graphics;
            
            g.Clear(this.BackColor);

            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.FillPath(new SolidBrush(Color.FromArgb(255, 144, 183, 213)), DrawRoundRect(0, 0, 148, 146, 146));

            g.DrawString("堆排序", new Font("微软雅黑", 9, FontStyle.Bold), new SolidBrush(Color.White), new PointF(55, 66));

            myBuffer.Render(e.Graphics);  //呈现图像至关联的Graphics

            myBuffer.Dispose();
            g.Dispose();
        }

        private void PnlStack_Click(object sender, EventArgs e)
        {
            StackSort S = new StackSort();
            StackSortHelp M = new StackSortHelp();

            S.Show();
            M.Show();
        }

        private void PnlMetro_Click(object sender, EventArgs e)
        {
            FrmMain F = new FrmMain();
            MetroHelp M = new MetroHelp();
            F.Show();
            M.Show();
        }
    }
}
