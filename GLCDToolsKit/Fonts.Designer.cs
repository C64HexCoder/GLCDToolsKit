namespace GLCDToolsKit
{
    partial class Fonts
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
            this.button1 = new System.Windows.Forms.Button();
            this.fontListComboBox = new System.Windows.Forms.ComboBox();
            this.fontSizeNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.fontDisp = new GfxLib.FontDisp();
            this.CharPB = new GfxLib.ImageBox();
            this.imageGrid = new GfxLib.ImageGrid();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeNumUpDown)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharPB)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fontListComboBox
            // 
            this.fontListComboBox.FormattingEnabled = true;
            this.fontListComboBox.Location = new System.Drawing.Point(12, 66);
            this.fontListComboBox.Name = "fontListComboBox";
            this.fontListComboBox.Size = new System.Drawing.Size(775, 28);
            this.fontListComboBox.TabIndex = 3;
            this.fontListComboBox.SelectedIndexChanged += new System.EventHandler(this.fontListComboBox_SelectedIndexChanged);
            // 
            // fontSizeNumUpDown
            // 
            this.fontSizeNumUpDown.Location = new System.Drawing.Point(668, 118);
            this.fontSizeNumUpDown.Name = "fontSizeNumUpDown";
            this.fontSizeNumUpDown.Size = new System.Drawing.Size(120, 26);
            this.fontSizeNumUpDown.TabIndex = 5;
            this.fontSizeNumUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 33);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFontToolStripMenuItem,
            this.rangeToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // selectFontToolStripMenuItem
            // 
            this.selectFontToolStripMenuItem.Name = "selectFontToolStripMenuItem";
            this.selectFontToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.selectFontToolStripMenuItem.Text = "Select Font";
            this.selectFontToolStripMenuItem.Click += new System.EventHandler(this.selectFontToolStripMenuItem_Click);
            // 
            // rangeToolStripMenuItem
            // 
            this.rangeToolStripMenuItem.Name = "rangeToolStripMenuItem";
            this.rangeToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.rangeToolStripMenuItem.Text = "Range";
            // 
            // fontDisp
            // 
            this.fontDisp.AutoSize = true;
            this.fontDisp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fontDisp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fontDisp.CellSizing = GfxLib.ImageGrid.CellSize.Fixed;
            this.fontDisp.CellsOnX = 8;
            this.fontDisp.CellsOnY = 8;
            this.fontDisp.CellsWidthHeight = 8;
            this.fontDisp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.fontDisp.Location = new System.Drawing.Point(229, 170);
            this.fontDisp.Name = "fontDisp";
            this.fontDisp.Size = new System.Drawing.Size(117, 90);
            this.fontDisp.TabIndex = 6;
            // 
            // CharPB
            // 
            this.CharPB.AutoScaleImageBox = true;
            this.CharPB.HrizontalScrollBar = null;
            this.CharPB.Image = null;
            this.CharPB.Location = new System.Drawing.Point(600, 159);
            this.CharPB.Name = "CharPB";
            this.CharPB.ScaleFactor = 10;
            this.CharPB.ScaleFactorFloat = 4F;
            this.CharPB.Size = new System.Drawing.Size(188, 298);
            this.CharPB.TabIndex = 4;
            this.CharPB.TabStop = false;
            this.CharPB.VerticalScrollBar = null;
            // 
            // imageGrid
            // 
            this.imageGrid.BackgroundColor = System.Drawing.Color.Transparent;
            this.imageGrid.CellBorder = true;
            this.imageGrid.CellSizing = GfxLib.ImageGrid.CellSize.Fixed;
            this.imageGrid.CellsOnX = 8;
            this.imageGrid.CellsOnY = 8;
            this.imageGrid.CellWIdthHeight = 15;
            this.imageGrid.DisplayMode = GfxLib.ImageGrid.DisplayModes.Mono;
            this.imageGrid.DrawColor = System.Drawing.Color.Blue;
            this.imageGrid.EnableDrawing = false;
            this.imageGrid.GridImage = null;
            this.imageGrid.KeepAspectRatio = true;
            this.imageGrid.LineWidth = 2;
            this.imageGrid.Location = new System.Drawing.Point(12, 170);
            this.imageGrid.Name = "imageGrid";
            this.imageGrid.ResizeToFitCells = GfxLib.ImageGrid.ResizeTypes.None;
            this.imageGrid.Size = new System.Drawing.Size(122, 122);
            this.imageGrid.TabIndex = 0;
            // 
            // Fonts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.fontDisp);
            this.Controls.Add(this.fontSizeNumUpDown);
            this.Controls.Add(this.CharPB);
            this.Controls.Add(this.fontListComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imageGrid);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Fonts";
            this.Text = "Fonts";
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeNumUpDown)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GfxLib.ImageGrid imageGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox fontListComboBox;
        private GfxLib.ImageBox CharPB;
        private System.Windows.Forms.NumericUpDown fontSizeNumUpDown;
        private GfxLib.FontDisp fontDisp;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rangeToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}