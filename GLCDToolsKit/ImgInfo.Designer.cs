namespace GLCDToolsKit
{
    partial class ImgInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImgInfo));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Width = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Width_tb = new System.Windows.Forms.Label();
            this.Height_tb = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ColorsLbl = new System.Windows.Forms.Label();
            this.BitsPerPixel = new System.Windows.Forms.Label();
            this.BppLbl = new System.Windows.Forms.Label();
            this.IndexedCb = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoCheck = false;
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBox1.Location = new System.Drawing.Point(18, 115);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(171, 29);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Transparenvy";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 352);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Width
            // 
            this.Width.AutoSize = true;
            this.Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Width.Location = new System.Drawing.Point(12, 13);
            this.Width.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(73, 26);
            this.Width.TabIndex = 4;
            this.Width.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(166, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Height";
            // 
            // Width_tb
            // 
            this.Width_tb.AutoSize = true;
            this.Width_tb.Location = new System.Drawing.Point(88, 13);
            this.Width_tb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Width_tb.Name = "Width_tb";
            this.Width_tb.Size = new System.Drawing.Size(48, 25);
            this.Width_tb.TabIndex = 7;
            this.Width_tb.Text = "128";
            // 
            // Height_tb
            // 
            this.Height_tb.AutoSize = true;
            this.Height_tb.Location = new System.Drawing.Point(250, 13);
            this.Height_tb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Height_tb.Name = "Height_tb";
            this.Height_tb.Size = new System.Drawing.Size(36, 25);
            this.Height_tb.TabIndex = 8;
            this.Height_tb.Text = "64";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(156, 188);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(128, 64);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(166, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Number of Colors";
            // 
            // ColorsLbl
            // 
            this.ColorsLbl.AutoSize = true;
            this.ColorsLbl.Location = new System.Drawing.Point(386, 58);
            this.ColorsLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ColorsLbl.Name = "ColorsLbl";
            this.ColorsLbl.Size = new System.Drawing.Size(48, 25);
            this.ColorsLbl.TabIndex = 11;
            this.ColorsLbl.Text = "256";
            // 
            // BitsPerPixel
            // 
            this.BitsPerPixel.AutoSize = true;
            this.BitsPerPixel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BitsPerPixel.Location = new System.Drawing.Point(12, 58);
            this.BitsPerPixel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BitsPerPixel.Name = "BitsPerPixel";
            this.BitsPerPixel.Size = new System.Drawing.Size(54, 26);
            this.BitsPerPixel.TabIndex = 12;
            this.BitsPerPixel.Text = "Bpp";
            // 
            // BppLbl
            // 
            this.BppLbl.AutoSize = true;
            this.BppLbl.Location = new System.Drawing.Point(78, 58);
            this.BppLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BppLbl.Name = "BppLbl";
            this.BppLbl.Size = new System.Drawing.Size(36, 25);
            this.BppLbl.TabIndex = 13;
            this.BppLbl.Text = "24";
            // 
            // IndexedCb
            // 
            this.IndexedCb.AutoCheck = false;
            this.IndexedCb.AutoSize = true;
            this.IndexedCb.Location = new System.Drawing.Point(206, 117);
            this.IndexedCb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.IndexedCb.Name = "IndexedCb";
            this.IndexedCb.Size = new System.Drawing.Size(120, 29);
            this.IndexedCb.TabIndex = 14;
            this.IndexedCb.Text = "Indexed";
            this.IndexedCb.UseVisualStyleBackColor = true;
            // 
            // ImgInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 410);
            this.Controls.Add(this.IndexedCb);
            this.Controls.Add(this.BppLbl);
            this.Controls.Add(this.BitsPerPixel);
            this.Controls.Add(this.ColorsLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.Height_tb);
            this.Controls.Add(this.Width_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ImgInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image info.";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private new System.Windows.Forms.Label Width;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Width_tb;
        private System.Windows.Forms.Label Height_tb;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ColorsLbl;
        private System.Windows.Forms.Label BitsPerPixel;
        private System.Windows.Forms.Label BppLbl;
        private System.Windows.Forms.CheckBox IndexedCb;
    }
}