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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.fontsDispPanel = new System.Windows.Forms.Panel();
            this.fromNumUD = new System.Windows.Forms.NumericUpDown();
            this.toNumUD = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.CharPB = new GfxLib.ImageBox();
            this.imageGrid = new GfxLib.ImageGrid();
            this.fontGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeNumUpDown)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharPB)).BeginInit();
            this.fontGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(894, 667);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fontListComboBox
            // 
            this.fontListComboBox.FormattingEnabled = true;
            this.fontListComboBox.Location = new System.Drawing.Point(26, 17);
            this.fontListComboBox.Name = "fontListComboBox";
            this.fontListComboBox.Size = new System.Drawing.Size(547, 28);
            this.fontListComboBox.TabIndex = 3;
            this.fontListComboBox.SelectedIndexChanged += new System.EventHandler(this.fontListComboBox_SelectedIndexChanged);
            // 
            // fontSizeNumUpDown
            // 
            this.fontSizeNumUpDown.Location = new System.Drawing.Point(579, 17);
            this.fontSizeNumUpDown.Name = "fontSizeNumUpDown";
            this.fontSizeNumUpDown.Size = new System.Drawing.Size(120, 26);
            this.fontSizeNumUpDown.TabIndex = 5;
            this.fontSizeNumUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.fontSizeNumUpDown.ValueChanged += new System.EventHandler(this.fontSizeNumUpDown_ValueChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(981, 36);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 32);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveSourceAsToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFontToolStripMenuItem,
            this.rangeToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(64, 32);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // selectFontToolStripMenuItem
            // 
            this.selectFontToolStripMenuItem.Name = "selectFontToolStripMenuItem";
            this.selectFontToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.selectFontToolStripMenuItem.Text = "Select Font";
            this.selectFontToolStripMenuItem.Click += new System.EventHandler(this.loadSystemFontToolStripMenuItem_Click);
            // 
            // rangeToolStripMenuItem
            // 
            this.rangeToolStripMenuItem.Name = "rangeToolStripMenuItem";
            this.rangeToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.rangeToolStripMenuItem.Text = "Range";
            // 
            // fontsDispPanel
            // 
            this.fontsDispPanel.AutoScroll = true;
            this.fontsDispPanel.Location = new System.Drawing.Point(591, 99);
            this.fontsDispPanel.Name = "fontsDispPanel";
            this.fontsDispPanel.Size = new System.Drawing.Size(378, 562);
            this.fontsDispPanel.TabIndex = 8;
            // 
            // fromNumUD
            // 
            this.fromNumUD.Location = new System.Drawing.Point(705, 17);
            this.fromNumUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.fromNumUD.Name = "fromNumUD";
            this.fromNumUD.Size = new System.Drawing.Size(120, 26);
            this.fromNumUD.TabIndex = 9;
            this.fromNumUD.Value = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.fromNumUD.ValueChanged += new System.EventHandler(this.toFromNumUD_ValueChanged);
            // 
            // toNumUD
            // 
            this.toNumUD.Location = new System.Drawing.Point(831, 17);
            this.toNumUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.toNumUD.Name = "toNumUD";
            this.toNumUD.Size = new System.Drawing.Size(120, 26);
            this.toNumUD.TabIndex = 10;
            this.toNumUD.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.toNumUD.ValueChanged += new System.EventHandler(this.toFromNumUD_ValueChanged);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "C/CPP Source File|*.c|Asm Source File|*.a";
            // 
            // CharPB
            // 
            this.CharPB.AutoScaleImageBox = true;
            this.CharPB.HrizontalScrollBar = null;
            this.CharPB.Image = null;
            this.CharPB.Location = new System.Drawing.Point(454, 99);
            this.CharPB.Name = "CharPB";
            this.CharPB.ScaleFactor = 10;
            this.CharPB.ScaleFactorFloat = 4F;
            this.CharPB.Size = new System.Drawing.Size(131, 382);
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
            this.imageGrid.Location = new System.Drawing.Point(12, 130);
            this.imageGrid.Name = "imageGrid";
            this.imageGrid.ResizeToFitCells = GfxLib.ImageGrid.ResizeTypes.None;
            this.imageGrid.Size = new System.Drawing.Size(122, 122);
            this.imageGrid.TabIndex = 0;
            // 
            // fontGroupBox
            // 
            this.fontGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.fontGroupBox.Controls.Add(this.fontListComboBox);
            this.fontGroupBox.Controls.Add(this.toNumUD);
            this.fontGroupBox.Controls.Add(this.fontSizeNumUpDown);
            this.fontGroupBox.Controls.Add(this.fromNumUD);
            this.fontGroupBox.Location = new System.Drawing.Point(12, 36);
            this.fontGroupBox.Name = "fontGroupBox";
            this.fontGroupBox.Size = new System.Drawing.Size(957, 57);
            this.fontGroupBox.TabIndex = 11;
            this.fontGroupBox.TabStop = false;
            this.fontGroupBox.Text = "Font";
            // 
            // Fonts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 708);
            this.Controls.Add(this.fontGroupBox);
            this.Controls.Add(this.fontsDispPanel);
            this.Controls.Add(this.CharPB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imageGrid);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Fonts";
            this.Text = "Fonts";
            this.Load += new System.EventHandler(this.Fonts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeNumUpDown)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharPB)).EndInit();
            this.fontGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GfxLib.ImageGrid imageGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox fontListComboBox;
        private GfxLib.ImageBox CharPB;
        private System.Windows.Forms.NumericUpDown fontSizeNumUpDown;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rangeToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Panel fontsDispPanel;
        private System.Windows.Forms.NumericUpDown fromNumUD;
        private System.Windows.Forms.NumericUpDown toNumUD;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox fontGroupBox;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    }
}