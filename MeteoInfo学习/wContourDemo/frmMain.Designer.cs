﻿namespace wContourDemo
{
    partial class frmMain
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
            this.Lab_EndColor = new System.Windows.Forms.Label();
            this.Lab_StartColor = new System.Windows.Forms.Label();
            this.TSSL_Coord = new System.Windows.Forms.ToolStripStatusLabel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_RandomData = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Interpolate = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_IDWNeighbour = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_IDWRadius = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Cressman = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Streamline = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_About = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.GB_DrawSet = new System.Windows.Forms.GroupBox();
            this.CB_BorderLines = new System.Windows.Forms.CheckBox();
            this.CB_ContourPolygon = new System.Windows.Forms.CheckBox();
            this.CB_ContourLine = new System.Windows.Forms.CheckBox();
            this.CB_GridData = new System.Windows.Forms.CheckBox();
            this.CB_DiscreteData = new System.Windows.Forms.CheckBox();
            this.TB_Hightlight = new System.Windows.Forms.TextBox();
            this.CB_Clipped = new System.Windows.Forms.CheckBox();
            this.ChB_Highlight = new System.Windows.Forms.CheckBox();
            this.ChB_AntiAlias = new System.Windows.Forms.CheckBox();
            this.B_OutputData = new System.Windows.Forms.Button();
            this.TSMI_Test = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.StatusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.GB_DrawSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lab_EndColor
            // 
            this.Lab_EndColor.AutoSize = true;
            this.Lab_EndColor.BackColor = System.Drawing.Color.Red;
            this.Lab_EndColor.Location = new System.Drawing.Point(541, 61);
            this.Lab_EndColor.Name = "Lab_EndColor";
            this.Lab_EndColor.Size = new System.Drawing.Size(59, 12);
            this.Lab_EndColor.TabIndex = 39;
            this.Lab_EndColor.Text = "End Color";
            this.Lab_EndColor.Click += new System.EventHandler(this.Lab_EndColor_Click);
            // 
            // Lab_StartColor
            // 
            this.Lab_StartColor.AutoSize = true;
            this.Lab_StartColor.BackColor = System.Drawing.Color.LightYellow;
            this.Lab_StartColor.Location = new System.Drawing.Point(538, 39);
            this.Lab_StartColor.Name = "Lab_StartColor";
            this.Lab_StartColor.Size = new System.Drawing.Size(71, 12);
            this.Lab_StartColor.TabIndex = 38;
            this.Lab_StartColor.Text = "Start Color";
            this.Lab_StartColor.Click += new System.EventHandler(this.Lab_StartColor_Click);
            // 
            // TSSL_Coord
            // 
            this.TSSL_Coord.Name = "TSSL_Coord";
            this.TSSL_Coord.Size = new System.Drawing.Size(17, 17);
            this.TSSL_Coord.Text = "...";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Location = new System.Drawing.Point(0, 83);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(795, 419);
            this.PictureBox1.TabIndex = 24;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.PictureBox1.Resize += new System.EventHandler(this.PictureBox1_Resize);
            this.PictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL_Coord});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 502);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(795, 22);
            this.StatusStrip1.TabIndex = 23;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 25);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_RandomData,
            this.TSMI_Interpolate,
            this.TSMI_Streamline,
            this.TSMI_Test});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.dataToolStripMenuItem.Text = "Sample";
            // 
            // TSMI_RandomData
            // 
            this.TSMI_RandomData.Name = "TSMI_RandomData";
            this.TSMI_RandomData.Size = new System.Drawing.Size(156, 22);
            this.TSMI_RandomData.Text = "Random Data";
            this.TSMI_RandomData.Click += new System.EventHandler(this.TSMI_RandomData_Click);
            // 
            // TSMI_Interpolate
            // 
            this.TSMI_Interpolate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_IDWNeighbour,
            this.TSMI_IDWRadius,
            this.TSMI_Cressman});
            this.TSMI_Interpolate.Name = "TSMI_Interpolate";
            this.TSMI_Interpolate.Size = new System.Drawing.Size(156, 22);
            this.TSMI_Interpolate.Text = "Interpolate";
            // 
            // TSMI_IDWNeighbour
            // 
            this.TSMI_IDWNeighbour.Name = "TSMI_IDWNeighbour";
            this.TSMI_IDWNeighbour.Size = new System.Drawing.Size(169, 22);
            this.TSMI_IDWNeighbour.Text = "IDW_Neighbour";
            this.TSMI_IDWNeighbour.Click += new System.EventHandler(this.TSMI_IDWNeighbour_Click);
            // 
            // TSMI_IDWRadius
            // 
            this.TSMI_IDWRadius.Name = "TSMI_IDWRadius";
            this.TSMI_IDWRadius.Size = new System.Drawing.Size(169, 22);
            this.TSMI_IDWRadius.Text = "IDW_Radius";
            this.TSMI_IDWRadius.Click += new System.EventHandler(this.TSMI_IDWRadius_Click);
            // 
            // TSMI_Cressman
            // 
            this.TSMI_Cressman.Name = "TSMI_Cressman";
            this.TSMI_Cressman.Size = new System.Drawing.Size(169, 22);
            this.TSMI_Cressman.Text = "Cressman";
            this.TSMI_Cressman.Click += new System.EventHandler(this.TSMI_Cressman_Click);
            // 
            // TSMI_Streamline
            // 
            this.TSMI_Streamline.Name = "TSMI_Streamline";
            this.TSMI_Streamline.Size = new System.Drawing.Size(156, 22);
            this.TSMI_Streamline.Text = "Streamline";
            this.TSMI_Streamline.Click += new System.EventHandler(this.TSMI_Streamline_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_About,
            this.TSMI_Help});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // TSMI_About
            // 
            this.TSMI_About.Name = "TSMI_About";
            this.TSMI_About.Size = new System.Drawing.Size(152, 22);
            this.TSMI_About.Text = "About";
            this.TSMI_About.Click += new System.EventHandler(this.TSMI_About_Click);
            // 
            // TSMI_Help
            // 
            this.TSMI_Help.Name = "TSMI_Help";
            this.TSMI_Help.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Help.Text = "Help";
            this.TSMI_Help.Click += new System.EventHandler(this.TSMI_Help_Click);
            // 
            // GB_DrawSet
            // 
            this.GB_DrawSet.Controls.Add(this.CB_BorderLines);
            this.GB_DrawSet.Controls.Add(this.CB_ContourPolygon);
            this.GB_DrawSet.Controls.Add(this.CB_ContourLine);
            this.GB_DrawSet.Controls.Add(this.CB_GridData);
            this.GB_DrawSet.Controls.Add(this.CB_DiscreteData);
            this.GB_DrawSet.Location = new System.Drawing.Point(10, 28);
            this.GB_DrawSet.Name = "GB_DrawSet";
            this.GB_DrawSet.Size = new System.Drawing.Size(511, 49);
            this.GB_DrawSet.TabIndex = 43;
            this.GB_DrawSet.TabStop = false;
            // 
            // CB_BorderLines
            // 
            this.CB_BorderLines.AutoSize = true;
            this.CB_BorderLines.Location = new System.Drawing.Point(201, 20);
            this.CB_BorderLines.Name = "CB_BorderLines";
            this.CB_BorderLines.Size = new System.Drawing.Size(84, 16);
            this.CB_BorderLines.TabIndex = 35;
            this.CB_BorderLines.Text = "BorderLine";
            this.CB_BorderLines.UseVisualStyleBackColor = true;
            this.CB_BorderLines.CheckedChanged += new System.EventHandler(this.CB_BorderLines_CheckedChanged);
            // 
            // CB_ContourPolygon
            // 
            this.CB_ContourPolygon.AutoSize = true;
            this.CB_ContourPolygon.Location = new System.Drawing.Point(387, 20);
            this.CB_ContourPolygon.Name = "CB_ContourPolygon";
            this.CB_ContourPolygon.Size = new System.Drawing.Size(108, 16);
            this.CB_ContourPolygon.TabIndex = 34;
            this.CB_ContourPolygon.Text = "ContourPolygon";
            this.CB_ContourPolygon.UseVisualStyleBackColor = true;
            this.CB_ContourPolygon.CheckedChanged += new System.EventHandler(this.CB_ContourPolygon_CheckedChanged);
            // 
            // CB_ContourLine
            // 
            this.CB_ContourLine.AutoSize = true;
            this.CB_ContourLine.Location = new System.Drawing.Point(291, 20);
            this.CB_ContourLine.Name = "CB_ContourLine";
            this.CB_ContourLine.Size = new System.Drawing.Size(90, 16);
            this.CB_ContourLine.TabIndex = 33;
            this.CB_ContourLine.Text = "ContourLine";
            this.CB_ContourLine.UseVisualStyleBackColor = true;
            this.CB_ContourLine.CheckedChanged += new System.EventHandler(this.CB_ContourLine_CheckedChanged);
            // 
            // CB_GridData
            // 
            this.CB_GridData.AutoSize = true;
            this.CB_GridData.Location = new System.Drawing.Point(123, 20);
            this.CB_GridData.Name = "CB_GridData";
            this.CB_GridData.Size = new System.Drawing.Size(72, 16);
            this.CB_GridData.TabIndex = 32;
            this.CB_GridData.Text = "GridData";
            this.CB_GridData.UseVisualStyleBackColor = true;
            this.CB_GridData.CheckedChanged += new System.EventHandler(this.CB_GridData_CheckedChanged);
            // 
            // CB_DiscreteData
            // 
            this.CB_DiscreteData.AutoSize = true;
            this.CB_DiscreteData.Location = new System.Drawing.Point(15, 20);
            this.CB_DiscreteData.Name = "CB_DiscreteData";
            this.CB_DiscreteData.Size = new System.Drawing.Size(96, 16);
            this.CB_DiscreteData.TabIndex = 31;
            this.CB_DiscreteData.Text = "DiscreteData";
            this.CB_DiscreteData.UseVisualStyleBackColor = true;
            this.CB_DiscreteData.CheckedChanged += new System.EventHandler(this.CB_DiscreteData_CheckedChanged);
            // 
            // TB_Hightlight
            // 
            this.TB_Hightlight.Location = new System.Drawing.Point(396, 4);
            this.TB_Hightlight.Name = "TB_Hightlight";
            this.TB_Hightlight.Size = new System.Drawing.Size(41, 21);
            this.TB_Hightlight.TabIndex = 45;
            this.TB_Hightlight.Text = "0";
            this.TB_Hightlight.TextChanged += new System.EventHandler(this.TB_Hightlight_TextChanged);
            // 
            // CB_Clipped
            // 
            this.CB_Clipped.AutoSize = true;
            this.CB_Clipped.Location = new System.Drawing.Point(233, 6);
            this.CB_Clipped.Name = "CB_Clipped";
            this.CB_Clipped.Size = new System.Drawing.Size(66, 16);
            this.CB_Clipped.TabIndex = 46;
            this.CB_Clipped.Text = "Clipped";
            this.CB_Clipped.UseVisualStyleBackColor = true;
            this.CB_Clipped.CheckedChanged += new System.EventHandler(this.CB_Clipped_CheckedChanged);
            // 
            // ChB_Highlight
            // 
            this.ChB_Highlight.AutoSize = true;
            this.ChB_Highlight.Location = new System.Drawing.Point(317, 6);
            this.ChB_Highlight.Name = "ChB_Highlight";
            this.ChB_Highlight.Size = new System.Drawing.Size(78, 16);
            this.ChB_Highlight.TabIndex = 47;
            this.ChB_Highlight.Text = "Highlight";
            this.ChB_Highlight.UseVisualStyleBackColor = true;
            this.ChB_Highlight.CheckedChanged += new System.EventHandler(this.ChB_Highlight_CheckedChanged);
            // 
            // ChB_AntiAlias
            // 
            this.ChB_AntiAlias.AutoSize = true;
            this.ChB_AntiAlias.Location = new System.Drawing.Point(455, 6);
            this.ChB_AntiAlias.Name = "ChB_AntiAlias";
            this.ChB_AntiAlias.Size = new System.Drawing.Size(78, 16);
            this.ChB_AntiAlias.TabIndex = 48;
            this.ChB_AntiAlias.Text = "AntiAlias";
            this.ChB_AntiAlias.UseVisualStyleBackColor = true;
            this.ChB_AntiAlias.CheckedChanged += new System.EventHandler(this.ChB_AntiAlias_CheckedChanged);
            // 
            // B_OutputData
            // 
            this.B_OutputData.Location = new System.Drawing.Point(646, 39);
            this.B_OutputData.Name = "B_OutputData";
            this.B_OutputData.Size = new System.Drawing.Size(90, 28);
            this.B_OutputData.TabIndex = 49;
            this.B_OutputData.Text = "Output Data";
            this.B_OutputData.UseVisualStyleBackColor = true;
            this.B_OutputData.Click += new System.EventHandler(this.B_OutputData_Click_1);
            // 
            // TSMI_Test
            // 
            this.TSMI_Test.Name = "TSMI_Test";
            this.TSMI_Test.Size = new System.Drawing.Size(156, 22);
            this.TSMI_Test.Text = "Test";
            this.TSMI_Test.Click += new System.EventHandler(this.TSMI_Test_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 524);
            this.Controls.Add(this.B_OutputData);
            this.Controls.Add(this.ChB_AntiAlias);
            this.Controls.Add(this.ChB_Highlight);
            this.Controls.Add(this.CB_Clipped);
            this.Controls.Add(this.TB_Hightlight);
            this.Controls.Add(this.GB_DrawSet);
            this.Controls.Add(this.Lab_EndColor);
            this.Controls.Add(this.Lab_StartColor);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "wContour Demo";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GB_DrawSet.ResumeLayout(false);
            this.GB_DrawSet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Lab_EndColor;
        internal System.Windows.Forms.Label Lab_StartColor;
        internal System.Windows.Forms.ToolStripStatusLabel TSSL_Coord;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_RandomData;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Interpolate;
        private System.Windows.Forms.ToolStripMenuItem TSMI_IDWNeighbour;
        private System.Windows.Forms.ToolStripMenuItem TSMI_IDWRadius;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Cressman;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Streamline;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_About;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help;
        internal System.Windows.Forms.GroupBox GB_DrawSet;
        internal System.Windows.Forms.CheckBox CB_DiscreteData;
        internal System.Windows.Forms.CheckBox CB_ContourLine;
        internal System.Windows.Forms.CheckBox CB_GridData;
        internal System.Windows.Forms.CheckBox CB_ContourPolygon;
        internal System.Windows.Forms.CheckBox CB_BorderLines;
        private System.Windows.Forms.TextBox TB_Hightlight;
        private System.Windows.Forms.CheckBox CB_Clipped;
        private System.Windows.Forms.CheckBox ChB_Highlight;
        private System.Windows.Forms.CheckBox ChB_AntiAlias;
        private System.Windows.Forms.Button B_OutputData;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Test;
    }
}