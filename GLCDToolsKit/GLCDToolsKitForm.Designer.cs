namespace GLCDToolsKit
{
    partial class GLCDToolsKitForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GLCDToolsKitForm));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Filename_tb = new System.Windows.Forms.TextBox();
            this.imageLable = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCFileToolSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PalleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToMonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sizeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Output_sl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.FileExt_sl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Compression_sl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.bpp_s1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Indexed_s1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BGColorButton = new System.Windows.Forms.Button();
            this.Convert_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.LoadImageBtn = new System.Windows.Forms.Button();
            this.RegistrationTimer = new System.Windows.Forms.Timer(this.components);
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(18, 775);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1065, 35);
            this.progressBar.TabIndex = 1;
            // 
            // Filename_tb
            // 
            this.Filename_tb.Location = new System.Drawing.Point(18, 78);
            this.Filename_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Filename_tb.Name = "Filename_tb";
            this.Filename_tb.Size = new System.Drawing.Size(1021, 26);
            this.Filename_tb.TabIndex = 3;
            // 
            // imageLable
            // 
            this.imageLable.AutoSize = true;
            this.imageLable.Location = new System.Drawing.Point(14, 54);
            this.imageLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imageLable.Name = "imageLable";
            this.imageLable.Size = new System.Drawing.Size(54, 20);
            this.imageLable.TabIndex = 4;
            this.imageLable.Text = "Image";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1101, 35);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.saveCFileToolSMenuItem,
            this.toolStripSeparator1,
            this.saveImageToolStripMenuItem,
            this.saveImageAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Image = global::GLCDToolsKit.Properties.Resources.folder_image;
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(344, 34);
            this.openImageToolStripMenuItem.Text = "Open Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // saveCFileToolSMenuItem
            // 
            this.saveCFileToolSMenuItem.Enabled = false;
            this.saveCFileToolSMenuItem.Image = global::GLCDToolsKit.Properties.Resources.disk_pen_save_save_as_write;
            this.saveCFileToolSMenuItem.Name = "saveCFileToolSMenuItem";
            this.saveCFileToolSMenuItem.Size = new System.Drawing.Size(344, 34);
            this.saveCFileToolSMenuItem.Text = "Convert and Save File";
            this.saveCFileToolSMenuItem.Click += new System.EventHandler(this.saveCFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(341, 6);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Image = global::GLCDToolsKit.Properties.Resources.floppy_unmount;
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(344, 34);
            this.saveImageToolStripMenuItem.Text = "Save Monochrome Image";
            this.saveImageToolStripMenuItem.Visible = false;
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // saveImageAsToolStripMenuItem
            // 
            this.saveImageAsToolStripMenuItem.Image = global::GLCDToolsKit.Properties.Resources.disk_pen_save_save_as_write;
            this.saveImageAsToolStripMenuItem.Name = "saveImageAsToolStripMenuItem";
            this.saveImageAsToolStripMenuItem.Size = new System.Drawing.Size(344, 34);
            this.saveImageAsToolStripMenuItem.Text = "Save Monochrome Image As";
            this.saveImageAsToolStripMenuItem.Click += new System.EventHandler(this.saveImageAsToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageInformationToolStripMenuItem,
            this.PalleteMenu,
            this.propertiesToolStripMenuItem,
            this.convertToMonoToolStripMenuItem,
            this.charEditorToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.infoToolStripMenuItem.Text = "Tools";
            // 
            // imageInformationToolStripMenuItem
            // 
            this.imageInformationToolStripMenuItem.Enabled = false;
            this.imageInformationToolStripMenuItem.Image = global::GLCDToolsKit.Properties.Resources.image_photo_thumbnail;
            this.imageInformationToolStripMenuItem.Name = "imageInformationToolStripMenuItem";
            this.imageInformationToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.imageInformationToolStripMenuItem.Text = "Image Information";
            this.imageInformationToolStripMenuItem.Click += new System.EventHandler(this.imageInformationToolStripMenuItem_Click);
            // 
            // PalleteMenu
            // 
            this.PalleteMenu.Enabled = false;
            this.PalleteMenu.Image = global::GLCDToolsKit.Properties.Resources.colorize;
            this.PalleteMenu.Name = "PalleteMenu";
            this.PalleteMenu.Size = new System.Drawing.Size(270, 34);
            this.PalleteMenu.Text = "Color Pallete";
            this.PalleteMenu.Click += new System.EventHandler(this.colorPalleteToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Image = global::GLCDToolsKit.Properties.Resources.card_chip_settings_tool;
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.propertiesToolStripMenuItem.Text = "Settings";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // convertToMonoToolStripMenuItem
            // 
            this.convertToMonoToolStripMenuItem.Enabled = false;
            this.convertToMonoToolStripMenuItem.Image = global::GLCDToolsKit.Properties.Resources.development_hammer_package_tool;
            this.convertToMonoToolStripMenuItem.Name = "convertToMonoToolStripMenuItem";
            this.convertToMonoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.convertToMonoToolStripMenuItem.Text = "Convert To Mono";
            this.convertToMonoToolStripMenuItem.ToolTipText = "Convert the image to monochrome";
            this.convertToMonoToolStripMenuItem.Click += new System.EventHandler(this.convertToMonoToolStripMenuItem_Click);
            // 
            // charEditorToolStripMenuItem
            // 
            this.charEditorToolStripMenuItem.Image = global::GLCDToolsKit.Properties.Resources.character_font_type;
            this.charEditorToolStripMenuItem.Name = "charEditorToolStripMenuItem";
            this.charEditorToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.charEditorToolStripMenuItem.Text = "Char editor";
            this.charEditorToolStripMenuItem.Click += new System.EventHandler(this.charEditorToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.docsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(65, 29);
            this.aboutToolStripMenuItem1.Text = "Help";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = global::GLCDToolsKit.Properties.Resources.help_question_mark;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // docsToolStripMenuItem
            // 
            this.docsToolStripMenuItem.Image = global::GLCDToolsKit.Properties.Resources.document;
            this.docsToolStripMenuItem.Name = "docsToolStripMenuItem";
            this.docsToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.docsToolStripMenuItem.Text = "Docs";
            this.docsToolStripMenuItem.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(208, 34);
            this.toolStripMenuItem1.Text = "Registration";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::GLCDToolsKit.Properties.Resources.help_question_mark_support;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.Color = System.Drawing.Color.White;
            this.colorDialog1.ShowHelp = true;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3,
            this.sizeStatusLabel,
            this.toolStripStatusLabel2,
            this.Output_sl,
            this.toolStripStatusLabel4,
            this.FileExt_sl,
            this.toolStripStatusLabel5,
            this.Compression_sl,
            this.toolStripStatusLabel6,
            this.bpp_s1,
            this.toolStripStatusLabel8,
            this.Indexed_s1});
            this.statusStrip.Location = new System.Drawing.Point(0, 790);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1101, 32);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "Select an Image file to convert to GLCD format";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Coral;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(145, 25);
            this.toolStripStatusLabel1.Text = "Load Image File";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(16, 25);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // sizeStatusLabel
            // 
            this.sizeStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sizeStatusLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sizeStatusLabel.Name = "sizeStatusLabel";
            this.sizeStatusLabel.Size = new System.Drawing.Size(51, 25);
            this.sizeStatusLabel.Text = "Size:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(16, 25);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // Output_sl
            // 
            this.Output_sl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Output_sl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Output_sl.Name = "Output_sl";
            this.Output_sl.Size = new System.Drawing.Size(78, 25);
            this.Output_sl.Text = "Output:";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(16, 25);
            this.toolStripStatusLabel4.Text = "|";
            // 
            // FileExt_sl
            // 
            this.FileExt_sl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.FileExt_sl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FileExt_sl.Name = "FileExt_sl";
            this.FileExt_sl.Size = new System.Drawing.Size(78, 25);
            this.FileExt_sl.Text = "File Ext:";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(16, 25);
            this.toolStripStatusLabel5.Text = "|";
            // 
            // Compression_sl
            // 
            this.Compression_sl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Compression_sl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Compression_sl.Name = "Compression_sl";
            this.Compression_sl.Size = new System.Drawing.Size(126, 25);
            this.Compression_sl.Text = "Compression:";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(16, 25);
            this.toolStripStatusLabel6.Text = "|";
            // 
            // bpp_s1
            // 
            this.bpp_s1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bpp_s1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bpp_s1.Name = "bpp_s1";
            this.bpp_s1.Size = new System.Drawing.Size(45, 25);
            this.bpp_s1.Text = "bpp";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(16, 25);
            this.toolStripStatusLabel8.Text = "|";
            // 
            // Indexed_s1
            // 
            this.Indexed_s1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Indexed_s1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Indexed_s1.Name = "Indexed_s1";
            this.Indexed_s1.Size = new System.Drawing.Size(99, 25);
            this.Indexed_s1.Text = "Indexed: ?";
            // 
            // BGColorButton
            // 
            this.BGColorButton.BackColor = System.Drawing.Color.White;
            this.BGColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGColorButton.Location = new System.Drawing.Point(18, 732);
            this.BGColorButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BGColorButton.Name = "BGColorButton";
            this.BGColorButton.Size = new System.Drawing.Size(33, 35);
            this.BGColorButton.TabIndex = 9;
            this.BGColorButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BGColorButton.UseVisualStyleBackColor = false;
            this.BGColorButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Convert_btn
            // 
            this.Convert_btn.Enabled = false;
            this.Convert_btn.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert_btn.ForeColor = System.Drawing.Color.Blue;
            this.Convert_btn.Location = new System.Drawing.Point(936, 706);
            this.Convert_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Convert_btn.Name = "Convert_btn";
            this.Convert_btn.Size = new System.Drawing.Size(147, 54);
            this.Convert_btn.TabIndex = 0;
            this.Convert_btn.Text = "Convert";
            this.Convert_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Convert_btn.UseVisualStyleBackColor = true;
            this.Convert_btn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(60, 740);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Background color";
            // 
            // LoadImageBtn
            // 
            this.LoadImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadImageBtn.Image = global::GLCDToolsKit.Properties.Resources.folder_image2;
            this.LoadImageBtn.Location = new System.Drawing.Point(1050, 78);
            this.LoadImageBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoadImageBtn.Name = "LoadImageBtn";
            this.LoadImageBtn.Size = new System.Drawing.Size(33, 31);
            this.LoadImageBtn.TabIndex = 5;
            this.LoadImageBtn.UseVisualStyleBackColor = true;
            this.LoadImageBtn.Click += new System.EventHandler(this.LoadImageBtn_Click);
            // 
            // RegistrationTimer
            // 
            this.RegistrationTimer.Interval = 30000;
            this.RegistrationTimer.Tick += new System.EventHandler(this.RegistrationTimer_Tick);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // GLCDToolsKitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1101, 822);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BGColorButton);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.LoadImageBtn);
            this.Controls.Add(this.imageLable);
            this.Controls.Add(this.Filename_tb);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Convert_btn);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GLCDToolsKitForm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GLCDToolsKit";
            this.Activated += new System.EventHandler(this.Activated_GLCD);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GLCDFormClosed);
            this.Leave += new System.EventHandler(this.LeaveForm);
            this.Validated += new System.EventHandler(this.GLCDToolsKitForm_Validated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Convert_btn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox Filename_tb;
        private System.Windows.Forms.Label imageLable;
        private System.Windows.Forms.Button LoadImageBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCFileToolSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PalleteMenu;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem convertToMonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel sizeStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem docsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem charEditorToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button BGColorButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel Output_sl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel FileExt_sl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel Compression_sl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel bpp_s1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel Indexed_s1;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.Timer RegistrationTimer;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
    }
}

