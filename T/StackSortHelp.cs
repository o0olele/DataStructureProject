using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T
{
    public partial class StackSortHelp : Form
    {
        public StackSortHelp()
        {
            InitializeComponent();
        }

        private int ClickCount = 0;

        private void PicStackHelp_Click(object sender, EventArgs e)
        {
            ClickCount++;
            if (ClickCount == 1)
                this.PicStackHelp.Image = T.Properties.Resources.StackHelp2;
            else if (ClickCount == 2)
                this.PicStackHelp.Image = T.Properties.Resources.Stackhelp3;
            else if (ClickCount == 3)
                this.PicStackHelp.Image = T.Properties.Resources.StackHelp4;
            else if (ClickCount == 4)
            {
                ClickCount = 0;
                this.PicStackHelp.Image = T.Properties.Resources.StackHelp1;
            }
        }
    }
}
