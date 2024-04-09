namespace GLCDToolsKit
{
    partial class Pallete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pallete));
            this.SetBGButton = new System.Windows.Forms.Button();
            this.button65 = new System.Windows.Forms.Button();
            this.Pallate = new GfxLib.Pallate();
            this.SuspendLayout();
            // 
            // SetBGButton
            // 
            this.SetBGButton.Location = new System.Drawing.Point(345, 585);
            this.SetBGButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SetBGButton.Name = "SetBGButton";
            this.SetBGButton.Size = new System.Drawing.Size(90, 35);
            this.SetBGButton.TabIndex = 72;
            this.SetBGButton.Text = "Update";
            this.SetBGButton.UseVisualStyleBackColor = true;
            this.SetBGButton.Click += new System.EventHandler(this.SetBGButton_Click);
            // 
            // button65
            // 
            this.button65.Location = new System.Drawing.Point(15, 585);
            this.button65.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button65.Name = "button65";
            this.button65.Size = new System.Drawing.Size(90, 35);
            this.button65.TabIndex = 73;
            this.button65.Text = "Cancel";
            this.button65.UseVisualStyleBackColor = true;
            this.button65.Click += new System.EventHandler(this.button65_Click);
            // 
            // Pallate
            // 
            this.Pallate.AlphChennel = true;
            this.Pallate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Pallate.Location = new System.Drawing.Point(12, 11);
            this.Pallate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pallate.Name = "Pallate";
            this.Pallate.NumOfColors = 4;
            this.Pallate.RGBVisible = true;
            this.Pallate.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(61)))), ((int)(((byte)(46)))));
            this.Pallate.SelectedColorBox = true;
            this.Pallate.SelectedColorIdx = ((byte)(0));
            this.Pallate.Size = new System.Drawing.Size(429, 553);
            this.Pallate.TabIndex = 74;
            // 
            // Pallete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 637);
            this.Controls.Add(this.Pallate);
            this.Controls.Add(this.button65);
            this.Controls.Add(this.SetBGButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Pallete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pallete";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SetBGButton;
        private System.Windows.Forms.Button button65;
        public GfxLib.Pallate Pallate;
    }
}