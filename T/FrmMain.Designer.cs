namespace T
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            T.MetroPath metroPath1 = new T.MetroPath();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabE = new System.Windows.Forms.Label();
            this.LabS = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.CobEnd = new System.Windows.Forms.ComboBox();
            this.CobStart = new System.Windows.Forms.ComboBox();
            this.LabNon = new System.Windows.Forms.Label();
            this.LabSearch = new System.Windows.Forms.Label();
            this.PnlAddNode = new System.Windows.Forms.Panel();
            this.LabNexXY = new System.Windows.Forms.Label();
            this.LabPreXY = new System.Windows.Forms.Label();
            this.CobNexNode = new System.Windows.Forms.ComboBox();
            this.CobPreNode = new System.Windows.Forms.ComboBox();
            this.BtnAddNodeX = new System.Windows.Forms.Button();
            this.BtnAddNode1 = new System.Windows.Forms.Button();
            this.BtnAddLine1 = new System.Windows.Forms.Button();
            this.BtnAddNodeC = new System.Windows.Forms.Button();
            this.LabNodeNex = new System.Windows.Forms.Label();
            this.LabNodePre = new System.Windows.Forms.Label();
            this.CobNodeLine = new System.Windows.Forms.ComboBox();
            this.LabNodeLine = new System.Windows.Forms.Label();
            this.LabNodeY = new System.Windows.Forms.Label();
            this.TxtNodeY = new System.Windows.Forms.TextBox();
            this.LabNodeX = new System.Windows.Forms.Label();
            this.TxtNodeX = new System.Windows.Forms.TextBox();
            this.LabNodeName = new System.Windows.Forms.Label();
            this.TxtNodeName = new System.Windows.Forms.TextBox();
            this.PnlAddLine = new System.Windows.Forms.Panel();
            this.BtnAddLineX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnColor = new System.Windows.Forms.Button();
            this.BtnAddNode2 = new System.Windows.Forms.Button();
            this.BtnAddLine2 = new System.Windows.Forms.Button();
            this.BtnAddLineC = new System.Windows.Forms.Button();
            this.LabLineName = new System.Windows.Forms.Label();
            this.TxtLineName = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.BtnMetroHelp = new System.Windows.Forms.Button();
            this.PicBoxList = new System.Windows.Forms.PictureBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.metroGraphView1 = new T.MetroGraphView();
            this.panel1.SuspendLayout();
            this.PnlAddNode.SuspendLayout();
            this.PnlAddLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LabE);
            this.panel1.Controls.Add(this.LabS);
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Controls.Add(this.CobEnd);
            this.panel1.Controls.Add(this.CobStart);
            this.panel1.Controls.Add(this.LabNon);
            this.panel1.Controls.Add(this.LabSearch);
            this.panel1.Location = new System.Drawing.Point(28, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 179);
            this.panel1.TabIndex = 1;
            // 
            // LabE
            // 
            this.LabE.AutoSize = true;
            this.LabE.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabE.Location = new System.Drawing.Point(19, 127);
            this.LabE.Name = "LabE";
            this.LabE.Size = new System.Drawing.Size(39, 20);
            this.LabE.TabIndex = 9;
            this.LabE.Text = "终点";
            // 
            // LabS
            // 
            this.LabS.AutoSize = true;
            this.LabS.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabS.Location = new System.Drawing.Point(19, 74);
            this.LabS.Name = "LabS";
            this.LabS.Size = new System.Drawing.Size(39, 20);
            this.LabS.TabIndex = 8;
            this.LabS.Text = "起点";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackgroundImage = global::T.Properties.Resources.Search;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Location = new System.Drawing.Point(370, 84);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(61, 54);
            this.BtnSearch.TabIndex = 7;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            this.BtnSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnSearch_Paint);
            // 
            // CobEnd
            // 
            this.CobEnd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CobEnd.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CobEnd.FormattingEnabled = true;
            this.CobEnd.Location = new System.Drawing.Point(64, 121);
            this.CobEnd.Name = "CobEnd";
            this.CobEnd.Size = new System.Drawing.Size(288, 32);
            this.CobEnd.TabIndex = 6;
            this.CobEnd.TextUpdate += new System.EventHandler(this.CobEnd_TextUpdate);
            this.CobEnd.SelectedValueChanged += new System.EventHandler(this.CobEnd_SelectedValueChanged);
            // 
            // CobStart
            // 
            this.CobStart.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CobStart.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CobStart.FormattingEnabled = true;
            this.CobStart.Location = new System.Drawing.Point(64, 68);
            this.CobStart.Name = "CobStart";
            this.CobStart.Size = new System.Drawing.Size(288, 32);
            this.CobStart.TabIndex = 5;
            this.CobStart.TextUpdate += new System.EventHandler(this.CobStart_TextUpdate);
            // 
            // LabNon
            // 
            this.LabNon.AutoSize = true;
            this.LabNon.Location = new System.Drawing.Point(223, 27);
            this.LabNon.Name = "LabNon";
            this.LabNon.Size = new System.Drawing.Size(55, 15);
            this.LabNon.TabIndex = 4;
            this.LabNon.Text = "label1";
            this.LabNon.Visible = false;
            this.LabNon.TextChanged += new System.EventHandler(this.LabNon_TextChanged);
            // 
            // LabSearch
            // 
            this.LabSearch.AutoSize = true;
            this.LabSearch.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabSearch.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabSearch.Location = new System.Drawing.Point(17, 15);
            this.LabSearch.Name = "LabSearch";
            this.LabSearch.Size = new System.Drawing.Size(88, 26);
            this.LabSearch.TabIndex = 3;
            this.LabSearch.Text = "换乘查询";
            // 
            // PnlAddNode
            // 
            this.PnlAddNode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnlAddNode.Controls.Add(this.LabNexXY);
            this.PnlAddNode.Controls.Add(this.LabPreXY);
            this.PnlAddNode.Controls.Add(this.CobNexNode);
            this.PnlAddNode.Controls.Add(this.CobPreNode);
            this.PnlAddNode.Controls.Add(this.BtnAddNodeX);
            this.PnlAddNode.Controls.Add(this.BtnAddNode1);
            this.PnlAddNode.Controls.Add(this.BtnAddLine1);
            this.PnlAddNode.Controls.Add(this.BtnAddNodeC);
            this.PnlAddNode.Controls.Add(this.LabNodeNex);
            this.PnlAddNode.Controls.Add(this.LabNodePre);
            this.PnlAddNode.Controls.Add(this.CobNodeLine);
            this.PnlAddNode.Controls.Add(this.LabNodeLine);
            this.PnlAddNode.Controls.Add(this.LabNodeY);
            this.PnlAddNode.Controls.Add(this.TxtNodeY);
            this.PnlAddNode.Controls.Add(this.LabNodeX);
            this.PnlAddNode.Controls.Add(this.TxtNodeX);
            this.PnlAddNode.Controls.Add(this.LabNodeName);
            this.PnlAddNode.Controls.Add(this.TxtNodeName);
            this.PnlAddNode.Location = new System.Drawing.Point(28, 228);
            this.PnlAddNode.Name = "PnlAddNode";
            this.PnlAddNode.Size = new System.Drawing.Size(521, 340);
            this.PnlAddNode.TabIndex = 3;
            this.PnlAddNode.Visible = false;
            // 
            // LabNexXY
            // 
            this.LabNexXY.AutoSize = true;
            this.LabNexXY.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabNexXY.Location = new System.Drawing.Point(367, 169);
            this.LabNexXY.Name = "LabNexXY";
            this.LabNexXY.Size = new System.Drawing.Size(0, 20);
            this.LabNexXY.TabIndex = 21;
            // 
            // LabPreXY
            // 
            this.LabPreXY.AutoSize = true;
            this.LabPreXY.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabPreXY.Location = new System.Drawing.Point(119, 169);
            this.LabPreXY.Name = "LabPreXY";
            this.LabPreXY.Size = new System.Drawing.Size(0, 20);
            this.LabPreXY.TabIndex = 20;
            // 
            // CobNexNode
            // 
            this.CobNexNode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CobNexNode.FormattingEnabled = true;
            this.CobNexNode.Location = new System.Drawing.Point(341, 132);
            this.CobNexNode.Name = "CobNexNode";
            this.CobNexNode.Size = new System.Drawing.Size(152, 28);
            this.CobNexNode.TabIndex = 19;
            this.CobNexNode.TextUpdate += new System.EventHandler(this.CobNexNode_TextUpdate);
            this.CobNexNode.SelectedValueChanged += new System.EventHandler(this.CobNexNode_SelectedValueChanged);
            // 
            // CobPreNode
            // 
            this.CobPreNode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CobPreNode.FormattingEnabled = true;
            this.CobPreNode.Location = new System.Drawing.Point(104, 132);
            this.CobPreNode.Name = "CobPreNode";
            this.CobPreNode.Size = new System.Drawing.Size(152, 28);
            this.CobPreNode.TabIndex = 18;
            this.CobPreNode.TextUpdate += new System.EventHandler(this.CobPreNode_TextUpdate);
            this.CobPreNode.SelectedValueChanged += new System.EventHandler(this.CobPreNode_SelectedValueChanged);
            // 
            // BtnAddNodeX
            // 
            this.BtnAddNodeX.FlatAppearance.BorderSize = 0;
            this.BtnAddNodeX.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnAddNodeX.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAddNodeX.Location = new System.Drawing.Point(264, 274);
            this.BtnAddNodeX.Name = "BtnAddNodeX";
            this.BtnAddNodeX.Size = new System.Drawing.Size(93, 32);
            this.BtnAddNodeX.TabIndex = 17;
            this.BtnAddNodeX.Text = "Cancel";
            this.BtnAddNodeX.UseVisualStyleBackColor = true;
            this.BtnAddNodeX.Click += new System.EventHandler(this.BtnAddNodeX_Click);
            // 
            // BtnAddNode1
            // 
            this.BtnAddNode1.FlatAppearance.BorderSize = 0;
            this.BtnAddNode1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnAddNode1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAddNode1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddNode1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAddNode1.Location = new System.Drawing.Point(264, 3);
            this.BtnAddNode1.Name = "BtnAddNode1";
            this.BtnAddNode1.Size = new System.Drawing.Size(255, 34);
            this.BtnAddNode1.TabIndex = 16;
            this.BtnAddNode1.Text = "Add Node";
            this.BtnAddNode1.UseVisualStyleBackColor = true;
            this.BtnAddNode1.Click += new System.EventHandler(this.BtnAddNode1_Click);
            this.BtnAddNode1.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnAddNode1_Paint);
            // 
            // BtnAddLine1
            // 
            this.BtnAddLine1.FlatAppearance.BorderSize = 0;
            this.BtnAddLine1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnAddLine1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAddLine1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddLine1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAddLine1.Location = new System.Drawing.Point(3, 3);
            this.BtnAddLine1.Name = "BtnAddLine1";
            this.BtnAddLine1.Size = new System.Drawing.Size(255, 34);
            this.BtnAddLine1.TabIndex = 15;
            this.BtnAddLine1.Text = "Add Line";
            this.BtnAddLine1.UseVisualStyleBackColor = true;
            this.BtnAddLine1.Click += new System.EventHandler(this.BtnAddLine1_Click);
            this.BtnAddLine1.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnAddLine1_Paint);
            // 
            // BtnAddNodeC
            // 
            this.BtnAddNodeC.FlatAppearance.BorderSize = 0;
            this.BtnAddNodeC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnAddNodeC.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAddNodeC.Location = new System.Drawing.Point(165, 274);
            this.BtnAddNodeC.Name = "BtnAddNodeC";
            this.BtnAddNodeC.Size = new System.Drawing.Size(93, 32);
            this.BtnAddNodeC.TabIndex = 14;
            this.BtnAddNodeC.Text = "Confirm";
            this.BtnAddNodeC.UseVisualStyleBackColor = true;
            this.BtnAddNodeC.Click += new System.EventHandler(this.BtnAddNodeC_Click);
            // 
            // LabNodeNex
            // 
            this.LabNodeNex.AutoSize = true;
            this.LabNodeNex.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabNodeNex.Location = new System.Drawing.Point(266, 132);
            this.LabNodeNex.Name = "LabNodeNex";
            this.LabNodeNex.Size = new System.Drawing.Size(69, 25);
            this.LabNodeNex.TabIndex = 13;
            this.LabNodeNex.Text = "下一站";
            // 
            // LabNodePre
            // 
            this.LabNodePre.AutoSize = true;
            this.LabNodePre.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabNodePre.Location = new System.Drawing.Point(29, 132);
            this.LabNodePre.Name = "LabNodePre";
            this.LabNodePre.Size = new System.Drawing.Size(69, 25);
            this.LabNodePre.TabIndex = 11;
            this.LabNodePre.Text = "上一站";
            // 
            // CobNodeLine
            // 
            this.CobNodeLine.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CobNodeLine.FormattingEnabled = true;
            this.CobNodeLine.Items.AddRange(new object[] {
            "1号线",
            "2号线",
            "2号线东延段",
            "3号线",
            "4号线",
            "5号线",
            "6号线",
            "7号线",
            "8号线",
            "9号线",
            "10号线(新江湾城-航中路)",
            "10号线(新江湾城-虹桥火车站)",
            "12号线",
            "13号线",
            "11号线",
            "16号线",
            "17号线"});
            this.CobNodeLine.Location = new System.Drawing.Point(341, 71);
            this.CobNodeLine.Name = "CobNodeLine";
            this.CobNodeLine.Size = new System.Drawing.Size(152, 28);
            this.CobNodeLine.TabIndex = 9;
            // 
            // LabNodeLine
            // 
            this.LabNodeLine.AutoSize = true;
            this.LabNodeLine.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabNodeLine.Location = new System.Drawing.Point(285, 74);
            this.LabNodeLine.Name = "LabNodeLine";
            this.LabNodeLine.Size = new System.Drawing.Size(50, 25);
            this.LabNodeLine.TabIndex = 7;
            this.LabNodeLine.Text = "线路";
            // 
            // LabNodeY
            // 
            this.LabNodeY.AutoSize = true;
            this.LabNodeY.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabNodeY.Location = new System.Drawing.Point(312, 196);
            this.LabNodeY.Name = "LabNodeY";
            this.LabNodeY.Size = new System.Drawing.Size(23, 25);
            this.LabNodeY.TabIndex = 5;
            this.LabNodeY.Text = "Y";
            // 
            // TxtNodeY
            // 
            this.TxtNodeY.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtNodeY.Location = new System.Drawing.Point(341, 193);
            this.TxtNodeY.Name = "TxtNodeY";
            this.TxtNodeY.Size = new System.Drawing.Size(152, 31);
            this.TxtNodeY.TabIndex = 4;
            // 
            // LabNodeX
            // 
            this.LabNodeX.AutoSize = true;
            this.LabNodeX.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabNodeX.Location = new System.Drawing.Point(74, 196);
            this.LabNodeX.Name = "LabNodeX";
            this.LabNodeX.Size = new System.Drawing.Size(24, 25);
            this.LabNodeX.TabIndex = 3;
            this.LabNodeX.Text = "X";
            // 
            // TxtNodeX
            // 
            this.TxtNodeX.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtNodeX.Location = new System.Drawing.Point(104, 193);
            this.TxtNodeX.Name = "TxtNodeX";
            this.TxtNodeX.Size = new System.Drawing.Size(152, 31);
            this.TxtNodeX.TabIndex = 2;
            // 
            // LabNodeName
            // 
            this.LabNodeName.AutoSize = true;
            this.LabNodeName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabNodeName.Location = new System.Drawing.Point(29, 74);
            this.LabNodeName.Name = "LabNodeName";
            this.LabNodeName.Size = new System.Drawing.Size(69, 25);
            this.LabNodeName.TabIndex = 1;
            this.LabNodeName.Text = "站点名";
            // 
            // TxtNodeName
            // 
            this.TxtNodeName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtNodeName.Location = new System.Drawing.Point(104, 71);
            this.TxtNodeName.Name = "TxtNodeName";
            this.TxtNodeName.Size = new System.Drawing.Size(152, 31);
            this.TxtNodeName.TabIndex = 0;
            // 
            // PnlAddLine
            // 
            this.PnlAddLine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnlAddLine.Controls.Add(this.BtnAddLineX);
            this.PnlAddLine.Controls.Add(this.label1);
            this.PnlAddLine.Controls.Add(this.BtnColor);
            this.PnlAddLine.Controls.Add(this.BtnAddNode2);
            this.PnlAddLine.Controls.Add(this.BtnAddLine2);
            this.PnlAddLine.Controls.Add(this.BtnAddLineC);
            this.PnlAddLine.Controls.Add(this.LabLineName);
            this.PnlAddLine.Controls.Add(this.TxtLineName);
            this.PnlAddLine.Location = new System.Drawing.Point(28, 228);
            this.PnlAddLine.Name = "PnlAddLine";
            this.PnlAddLine.Size = new System.Drawing.Size(521, 340);
            this.PnlAddLine.TabIndex = 5;
            this.PnlAddLine.Visible = false;
            // 
            // BtnAddLineX
            // 
            this.BtnAddLineX.FlatAppearance.BorderSize = 0;
            this.BtnAddLineX.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnAddLineX.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAddLineX.Location = new System.Drawing.Point(264, 274);
            this.BtnAddLineX.Name = "BtnAddLineX";
            this.BtnAddLineX.Size = new System.Drawing.Size(93, 32);
            this.BtnAddLineX.TabIndex = 19;
            this.BtnAddLineX.Text = "Cancel";
            this.BtnAddLineX.UseVisualStyleBackColor = true;
            this.BtnAddLineX.Click += new System.EventHandler(this.BtnAddLineX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(11, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "选取颜色";
            // 
            // BtnColor
            // 
            this.BtnColor.Location = new System.Drawing.Point(105, 136);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(75, 34);
            this.BtnColor.TabIndex = 17;
            this.BtnColor.Tag = "";
            this.BtnColor.Text = "Color";
            this.BtnColor.UseVisualStyleBackColor = true;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // BtnAddNode2
            // 
            this.BtnAddNode2.FlatAppearance.BorderSize = 0;
            this.BtnAddNode2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnAddNode2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAddNode2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddNode2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAddNode2.Location = new System.Drawing.Point(264, 3);
            this.BtnAddNode2.Name = "BtnAddNode2";
            this.BtnAddNode2.Size = new System.Drawing.Size(255, 34);
            this.BtnAddNode2.TabIndex = 16;
            this.BtnAddNode2.Text = "Add Node";
            this.BtnAddNode2.UseVisualStyleBackColor = true;
            this.BtnAddNode2.Click += new System.EventHandler(this.BtnAddNode2_Click);
            this.BtnAddNode2.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnAddNode2_Paint);
            // 
            // BtnAddLine2
            // 
            this.BtnAddLine2.FlatAppearance.BorderSize = 0;
            this.BtnAddLine2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnAddLine2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAddLine2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddLine2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAddLine2.Location = new System.Drawing.Point(3, 3);
            this.BtnAddLine2.Name = "BtnAddLine2";
            this.BtnAddLine2.Size = new System.Drawing.Size(255, 34);
            this.BtnAddLine2.TabIndex = 15;
            this.BtnAddLine2.Text = "Add Line";
            this.BtnAddLine2.UseVisualStyleBackColor = true;
            this.BtnAddLine2.Click += new System.EventHandler(this.BtnAddLine2_Click);
            this.BtnAddLine2.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnAddLine2_Paint);
            // 
            // BtnAddLineC
            // 
            this.BtnAddLineC.BackgroundImage = global::T.Properties.Resources.Trans;
            this.BtnAddLineC.FlatAppearance.BorderSize = 0;
            this.BtnAddLineC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnAddLineC.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAddLineC.Location = new System.Drawing.Point(165, 274);
            this.BtnAddLineC.Name = "BtnAddLineC";
            this.BtnAddLineC.Size = new System.Drawing.Size(93, 32);
            this.BtnAddLineC.TabIndex = 14;
            this.BtnAddLineC.Text = "Confirm";
            this.BtnAddLineC.UseVisualStyleBackColor = true;
            this.BtnAddLineC.Click += new System.EventHandler(this.BtnAddLineC_Click);
            // 
            // LabLineName
            // 
            this.LabLineName.AutoSize = true;
            this.LabLineName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabLineName.Location = new System.Drawing.Point(29, 74);
            this.LabLineName.Name = "LabLineName";
            this.LabLineName.Size = new System.Drawing.Size(69, 25);
            this.LabLineName.TabIndex = 1;
            this.LabLineName.Text = "线路名";
            // 
            // TxtLineName
            // 
            this.TxtLineName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtLineName.Location = new System.Drawing.Point(104, 71);
            this.TxtLineName.Name = "TxtLineName";
            this.TxtLineName.Size = new System.Drawing.Size(152, 31);
            this.TxtLineName.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.White;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAdd.Location = new System.Drawing.Point(25, 213);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(61, 54);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAddNode_Click);
            this.BtnAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnAddNode_Paint);
            // 
            // BtnMetroHelp
            // 
            this.BtnMetroHelp.BackColor = System.Drawing.Color.White;
            this.BtnMetroHelp.FlatAppearance.BorderSize = 0;
            this.BtnMetroHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnMetroHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnMetroHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMetroHelp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnMetroHelp.Location = new System.Drawing.Point(25, 341);
            this.BtnMetroHelp.Name = "BtnMetroHelp";
            this.BtnMetroHelp.Size = new System.Drawing.Size(61, 54);
            this.BtnMetroHelp.TabIndex = 20;
            this.BtnMetroHelp.UseVisualStyleBackColor = false;
            this.BtnMetroHelp.Click += new System.EventHandler(this.BtnMetroHelp_Click);
            this.BtnMetroHelp.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnMetroHelp_Paint);
            // 
            // PicBoxList
            // 
            this.PicBoxList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.PicBoxList.Location = new System.Drawing.Point(28, 228);
            this.PicBoxList.Name = "PicBoxList";
            this.PicBoxList.Size = new System.Drawing.Size(400, 500);
            this.PicBoxList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicBoxList.TabIndex = 2;
            this.PicBoxList.TabStop = false;
            this.PicBoxList.Visible = false;
            this.PicBoxList.Paint += new System.Windows.Forms.PaintEventHandler(this.PicBoxList_Paint);
            this.PicBoxList.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.PicBoxList_MouseWheel);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.White;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSave.Location = new System.Drawing.Point(25, 276);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(61, 54);
            this.BtnSave.TabIndex = 21;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            this.BtnSave.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnSave_Paint);
            // 
            // metroGraphView1
            // 
            this.metroGraphView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGraphView1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroGraphView1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroGraphView1.BackgroundImage")));
            this.metroGraphView1.CurPath = metroPath1;
            this.metroGraphView1.EndNode = null;
            this.metroGraphView1.Location = new System.Drawing.Point(14, 14);
            this.metroGraphView1.Margin = new System.Windows.Forms.Padding(5);
            this.metroGraphView1.Name = "metroGraphView1";
            this.metroGraphView1.Size = new System.Drawing.Size(1326, 546);
            this.metroGraphView1.StartNode = null;
            this.metroGraphView1.TabIndex = 0;
            this.metroGraphView1.ZoomScale = 1F;
            this.metroGraphView1.BackColorChanged += new System.EventHandler(this.metroGraphView1_BackColorChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 577);
            this.Controls.Add(this.BtnMetroHelp);
            this.Controls.Add(this.PnlAddLine);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.PnlAddNode);
            this.Controls.Add(this.PicBoxList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroGraphView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMain";
            this.Text = "上海地铁交通线路图";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlAddNode.ResumeLayout(false);
            this.PnlAddNode.PerformLayout();
            this.PnlAddLine.ResumeLayout(false);
            this.PnlAddLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroGraphView metroGraphView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabSearch;
        private System.Windows.Forms.PictureBox PicBoxList;
        private System.Windows.Forms.Label LabNon;
        private System.Windows.Forms.Panel PnlAddNode;
        private System.Windows.Forms.Label LabNodeLine;
        private System.Windows.Forms.Label LabNodeY;
        private System.Windows.Forms.TextBox TxtNodeY;
        private System.Windows.Forms.Label LabNodeX;
        private System.Windows.Forms.TextBox TxtNodeX;
        private System.Windows.Forms.Label LabNodeName;
        private System.Windows.Forms.TextBox TxtNodeName;
        private System.Windows.Forms.ComboBox CobNodeLine;
        private System.Windows.Forms.Button BtnAddNodeC;
        private System.Windows.Forms.Label LabNodeNex;
        private System.Windows.Forms.Label LabNodePre;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ComboBox CobStart;
        private System.Windows.Forms.ComboBox CobEnd;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label LabE;
        private System.Windows.Forms.Label LabS;
        private System.Windows.Forms.Button BtnAddNode1;
        private System.Windows.Forms.Button BtnAddLine1;
        private System.Windows.Forms.Panel PnlAddLine;
        private System.Windows.Forms.Button BtnAddNode2;
        private System.Windows.Forms.Button BtnAddLine2;
        private System.Windows.Forms.Button BtnAddLineC;
        private System.Windows.Forms.Label LabLineName;
        private System.Windows.Forms.TextBox TxtLineName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button BtnAddLineX;
        private System.Windows.Forms.Button BtnAddNodeX;
        private System.Windows.Forms.ComboBox CobNexNode;
        private System.Windows.Forms.ComboBox CobPreNode;
        private System.Windows.Forms.Label LabNexXY;
        private System.Windows.Forms.Label LabPreXY;
        private System.Windows.Forms.Button BtnMetroHelp;
        private System.Windows.Forms.Button BtnSave;
    }
}