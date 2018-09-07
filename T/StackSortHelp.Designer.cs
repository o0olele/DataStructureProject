namespace T
{
    partial class StackSortHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StackSortHelp));
            this.PicStackHelp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicStackHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // PicStackHelp
            // 
            this.PicStackHelp.Image = global::T.Properties.Resources.StackHelp1;
            this.PicStackHelp.Location = new System.Drawing.Point(12, 7);
            this.PicStackHelp.Name = "PicStackHelp";
            this.PicStackHelp.Size = new System.Drawing.Size(1108, 753);
            this.PicStackHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicStackHelp.TabIndex = 0;
            this.PicStackHelp.TabStop = false;
            this.PicStackHelp.Click += new System.EventHandler(this.PicStackHelp_Click);
            // 
            // StackSortHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 772);
            this.Controls.Add(this.PicStackHelp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StackSortHelp";
            this.Text = "使用说明";
            ((System.ComponentModel.ISupportInitialize)(this.PicStackHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicStackHelp;
    }
}