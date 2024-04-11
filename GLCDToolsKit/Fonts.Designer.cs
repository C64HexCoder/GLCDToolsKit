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
            this.imageGrid = new GfxLib.ImageGrid();
            this.CharPB = new GfxLib.ImageBox();
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fontListComboBox
            // 
            this.fontListComboBox.FormattingEnabled = true;
            this.fontListComboBox.Location = new System.Drawing.Point(13, 13);
            this.fontListComboBox.Name = "fontListComboBox";
            this.fontListComboBox.Size = new System.Drawing.Size(775, 28);
            this.fontListComboBox.TabIndex = 3;
            this.fontListComboBox.SelectedIndexChanged += new System.EventHandler(this.fontListComboBox_SelectedIndexChanged);
            // 
            // imageGrid
            // 
            this.imageGrid.CellBorder = true;
            this.imageGrid.CellsOnX = 8;
            this.imageGrid.CellsOnY = 8;
            this.imageGrid.DrawColor = System.Drawing.Color.Blue;
            this.imageGrid.GridImage = null;
            this.imageGrid.KeepAspectRatio = true;
            this.imageGrid.LineWidth = 2;
            this.imageGrid.Location = new System.Drawing.Point(13, 58);
            this.imageGrid.Name = "imageGrid";
            this.imageGrid.Size = new System.Drawing.Size(280, 281);
            this.imageGrid.TabIndex = 0;
            this.imageGrid.Load += new System.EventHandler(this.imageGrid_Load);
            this.imageGrid.Validated += new System.EventHandler(this.imageGrid_Validated);
            // 
            // CharPB
            // 
            this.CharPB.AutoScaleImageBox = true;
            this.CharPB.HrizontalScrollBar = null;
            this.CharPB.Image = null;
            this.CharPB.Location = new System.Drawing.Point(600, 58);
            this.CharPB.Name = "CharPB";
            this.CharPB.ScaleFactor = 10;
            this.CharPB.ScaleFactorFloat = 4F;
            this.CharPB.Size = new System.Drawing.Size(188, 298);
            this.CharPB.TabIndex = 4;
            this.CharPB.TabStop = false;
            this.CharPB.VerticalScrollBar = null;
            // 
            // Fonts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.CharPB);
            this.Controls.Add(this.fontListComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imageGrid);
            this.Name = "Fonts";
            this.Text = "Fonts";
            ((System.ComponentModel.ISupportInitialize)(this.CharPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GfxLib.ImageGrid imageGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox fontListComboBox;
        private GfxLib.ImageBox CharPB;
    }
}