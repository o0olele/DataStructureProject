namespace T
{
    partial class StackSort
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StackSort));
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabStack = new System.Windows.Forms.Label();
            this.BtnStackRst = new System.Windows.Forms.Button();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.StackExit = new System.Windows.Forms.Button();
            this.RESTART = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SubOne = new System.Windows.Forms.Button();
            this.AddOne = new System.Windows.Forms.Button();
            this.ActionStep = new System.Windows.Forms.Button();
            this.ActionALL = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(83)))), ((int)(((byte)(141)))));
            this.panel2.Controls.Add(this.LabStack);
            this.panel2.Controls.Add(this.BtnStackRst);
            this.panel2.Controls.Add(this.BtnHelp);
            this.panel2.Controls.Add(this.StackExit);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 48);
            this.panel2.TabIndex = 7;
            // 
            // LabStack
            // 
            this.LabStack.AutoSize = true;
            this.LabStack.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabStack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(26)))), ((int)(((byte)(90)))));
            this.LabStack.Location = new System.Drawing.Point(27, 10);
            this.LabStack.Name = "LabStack";
            this.LabStack.Size = new System.Drawing.Size(72, 27);
            this.LabStack.TabIndex = 12;
            this.LabStack.Text = "堆排序";
            // 
            // BtnStackRst
            // 
            this.BtnStackRst.FlatAppearance.BorderSize = 0;
            this.BtnStackRst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnStackRst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnStackRst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStackRst.Location = new System.Drawing.Point(938, 8);
            this.BtnStackRst.Name = "BtnStackRst";
            this.BtnStackRst.Size = new System.Drawing.Size(75, 34);
            this.BtnStackRst.TabIndex = 11;
            this.BtnStackRst.Text = "Reset";
            this.BtnStackRst.UseVisualStyleBackColor = true;
            this.BtnStackRst.Click += new System.EventHandler(this.BtnStackRst_Click);
            this.BtnStackRst.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnStackRst_Paint);
            // 
            // BtnHelp
            // 
            this.BtnHelp.FlatAppearance.BorderSize = 0;
            this.BtnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHelp.Location = new System.Drawing.Point(1019, 8);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(75, 34);
            this.BtnHelp.TabIndex = 1;
            this.BtnHelp.Text = "Help";
            this.BtnHelp.UseVisualStyleBackColor = true;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            this.BtnHelp.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnHelp_Paint);
            // 
            // StackExit
            // 
            this.StackExit.FlatAppearance.BorderSize = 0;
            this.StackExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StackExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StackExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StackExit.Location = new System.Drawing.Point(1100, 8);
            this.StackExit.Name = "StackExit";
            this.StackExit.Size = new System.Drawing.Size(75, 34);
            this.StackExit.TabIndex = 0;
            this.StackExit.Text = "Exit";
            this.StackExit.UseVisualStyleBackColor = true;
            this.StackExit.Click += new System.EventHandler(this.StackExit_Click);
            this.StackExit.Paint += new System.Windows.Forms.PaintEventHandler(this.StackExit_Paint);
            // 
            // RESTART
            // 
            this.RESTART.FlatAppearance.BorderSize = 0;
            this.RESTART.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RESTART.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RESTART.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RESTART.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RESTART.Location = new System.Drawing.Point(525, 686);
            this.RESTART.Name = "RESTART";
            this.RESTART.Size = new System.Drawing.Size(75, 55);
            this.RESTART.TabIndex = 10;
            this.RESTART.Text = "Restart";
            this.RESTART.UseVisualStyleBackColor = true;
            this.RESTART.Visible = false;
            this.RESTART.Click += new System.EventHandler(this.RESTART_Click);
            this.RESTART.Paint += new System.Windows.Forms.PaintEventHandler(this.RESTART_Paint);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(512, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "堆排序";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // Next
            // 
            this.Next.FlatAppearance.BorderSize = 0;
            this.Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Next.Location = new System.Drawing.Point(1082, 271);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 55);
            this.Next.TabIndex = 2;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Visible = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            this.Next.Paint += new System.Windows.Forms.PaintEventHandler(this.Next_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(512, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 68);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(3, 19);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // SubOne
            // 
            this.SubOne.FlatAppearance.BorderSize = 0;
            this.SubOne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SubOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SubOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubOne.Location = new System.Drawing.Point(512, 76);
            this.SubOne.Name = "SubOne";
            this.SubOne.Size = new System.Drawing.Size(30, 23);
            this.SubOne.TabIndex = 5;
            this.SubOne.Text = "Sub";
            this.SubOne.UseVisualStyleBackColor = true;
            this.SubOne.Click += new System.EventHandler(this.SubOne_Click);
            this.SubOne.Paint += new System.Windows.Forms.PaintEventHandler(this.SubOne_Paint);
            // 
            // AddOne
            // 
            this.AddOne.FlatAppearance.BorderSize = 0;
            this.AddOne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOne.Location = new System.Drawing.Point(562, 76);
            this.AddOne.Name = "AddOne";
            this.AddOne.Size = new System.Drawing.Size(30, 23);
            this.AddOne.TabIndex = 6;
            this.AddOne.Text = "Add";
            this.AddOne.UseVisualStyleBackColor = true;
            this.AddOne.Click += new System.EventHandler(this.AddOne_Click);
            this.AddOne.Paint += new System.Windows.Forms.PaintEventHandler(this.AddOne_Paint);
            // 
            // ActionStep
            // 
            this.ActionStep.FlatAppearance.BorderSize = 0;
            this.ActionStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ActionStep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ActionStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActionStep.Location = new System.Drawing.Point(476, 76);
            this.ActionStep.Name = "ActionStep";
            this.ActionStep.Size = new System.Drawing.Size(75, 30);
            this.ActionStep.TabIndex = 8;
            this.ActionStep.Text = "单步执行";
            this.ActionStep.UseVisualStyleBackColor = true;
            this.ActionStep.Visible = false;
            this.ActionStep.Click += new System.EventHandler(this.ActionStep_Click);
            this.ActionStep.Paint += new System.Windows.Forms.PaintEventHandler(this.ActionStep_Paint);
            // 
            // ActionALL
            // 
            this.ActionALL.FlatAppearance.BorderSize = 0;
            this.ActionALL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ActionALL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ActionALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActionALL.Location = new System.Drawing.Point(557, 76);
            this.ActionALL.Name = "ActionALL";
            this.ActionALL.Size = new System.Drawing.Size(75, 30);
            this.ActionALL.TabIndex = 9;
            this.ActionALL.Text = "快速执行";
            this.ActionALL.UseVisualStyleBackColor = true;
            this.ActionALL.Visible = false;
            this.ActionALL.Click += new System.EventHandler(this.ActionALL_Click);
            this.ActionALL.Paint += new System.Windows.Forms.PaintEventHandler(this.ActionALL_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ActionALL);
            this.panel3.Controls.Add(this.ActionStep);
            this.panel3.Controls.Add(this.AddOne);
            this.panel3.Controls.Add(this.SubOne);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.Next);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(13, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1161, 679);
            this.panel3.TabIndex = 11;
            // 
            // StackSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.ControlBox = false;
            this.Controls.Add(this.RESTART);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 50);
            this.MaximizeBox = false;
            this.Name = "StackSort";
            this.Text = "堆排序";
            this.Activated += new System.EventHandler(this.StackSort_Activated);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button RESTART;
        private System.Windows.Forms.Button StackExit;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Button BtnStackRst;
        private System.Windows.Forms.Label LabStack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SubOne;
        private System.Windows.Forms.Button AddOne;
        private System.Windows.Forms.Button ActionStep;
        private System.Windows.Forms.Button ActionALL;
        private System.Windows.Forms.Panel panel3;
    }
}

