namespace T
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.PnlStack = new System.Windows.Forms.Panel();
            this.PnlMetro = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PnlStack
            // 
            this.PnlStack.Location = new System.Drawing.Point(65, 113);
            this.PnlStack.Name = "PnlStack";
            this.PnlStack.Size = new System.Drawing.Size(200, 189);
            this.PnlStack.TabIndex = 0;
            this.PnlStack.Click += new System.EventHandler(this.PnlStack_Click);
            this.PnlStack.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlStack_Paint);
            // 
            // PnlMetro
            // 
            this.PnlMetro.Location = new System.Drawing.Point(521, 113);
            this.PnlMetro.Name = "PnlMetro";
            this.PnlMetro.Size = new System.Drawing.Size(200, 189);
            this.PnlMetro.TabIndex = 1;
            this.PnlMetro.Click += new System.EventHandler(this.PnlMetro_Click);
            this.PnlMetro.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMetro_Paint);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlMetro);
            this.Controls.Add(this.PnlStack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlStack;
        private System.Windows.Forms.Panel PnlMetro;
    }
}