namespace GLCDToolsKit
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.OKBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Resolution = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.hightTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WidthTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LcdComBox = new System.Windows.Forms.ComboBox();
            this.Assembler = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UseFileNameAsLable_cb = new System.Windows.Forms.CheckBox();
            this.LableName_tb = new System.Windows.Forms.TextBox();
            this.file_Ext_GB = new System.Windows.Forms.GroupBox();
            this.a_File = new System.Windows.Forms.RadioButton();
            this.asm_File = new System.Windows.Forms.RadioButton();
            this.inc_File = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ArrayNameCB = new System.Windows.Forms.CheckBox();
            this.ArrayNameTB = new System.Windows.Forms.TextBox();
            this.NumBase = new System.Windows.Forms.GroupBox();
            this.Dec_rb = new System.Windows.Forms.RadioButton();
            this.Hex_rb = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cpp_file = new System.Windows.Forms.RadioButton();
            this.c_file = new System.Windows.Forms.RadioButton();
            this.c_header = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.MonoRb = new System.Windows.Forms.RadioButton();
            this.ColorRb = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.BytesPerLineCB = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.horizontalRB = new System.Windows.Forms.RadioButton();
            this.verticalRB = new System.Windows.Forms.RadioButton();
            this.ROM_Addr_tb = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.AVR_rb = new System.Windows.Forms.RadioButton();
            this.PIC_rb = new System.Windows.Forms.RadioButton();
            this.ProgramMemCk = new System.Windows.Forms.CheckBox();
            this.HeaderCB = new System.Windows.Forms.CheckBox();
            this.OutputGB = new System.Windows.Forms.GroupBox();
            this.ASM_rb = new System.Windows.Forms.RadioButton();
            this.Binary_rb = new System.Windows.Forms.RadioButton();
            this.C_rb = new System.Windows.Forms.RadioButton();
            this.RLEcompressionCB = new System.Windows.Forms.CheckBox();
            this.SettingsTabs = new System.Windows.Forms.TabControl();
            this.Screen = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Resolution.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Assembler.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.file_Ext_GB.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.NumBase.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.OutputGB.SuspendLayout();
            this.SettingsTabs.SuspendLayout();
            this.Screen.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(402, 318);
            this.OKBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(112, 35);
            this.OKBtn.TabIndex = 1;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 318);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Resolution
            // 
            this.Resolution.Controls.Add(this.groupBox5);
            this.Resolution.Controls.Add(this.groupBox4);
            this.Resolution.Location = new System.Drawing.Point(4, 29);
            this.Resolution.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Resolution.Name = "Resolution";
            this.Resolution.Size = new System.Drawing.Size(488, 258);
            this.Resolution.TabIndex = 0;
            this.Resolution.Text = "Resolution";
            this.Resolution.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.hightTB);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.WidthTB);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(12, 125);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(470, 91);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Manual";
            this.toolTip.SetToolTip(this.groupBox5, "Enter resolution manually");
            // 
            // hightTB
            // 
            this.hightTB.Location = new System.Drawing.Point(302, 34);
            this.hightTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hightTB.Name = "hightTB";
            this.hightTB.Size = new System.Drawing.Size(148, 26);
            this.hightTB.TabIndex = 17;
            this.hightTB.Text = "64";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Hight";
            // 
            // WidthTB
            // 
            this.WidthTB.Location = new System.Drawing.Point(86, 34);
            this.WidthTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WidthTB.Name = "WidthTB";
            this.WidthTB.Size = new System.Drawing.Size(148, 26);
            this.WidthTB.TabIndex = 15;
            this.WidthTB.Text = "128";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Width";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LcdComBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(249, 65);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "By Selecting LCD";
            // 
            // LcdComBox
            // 
            this.LcdComBox.FormattingEnabled = true;
            this.LcdComBox.Items.AddRange(new object[] {
            "128x64 GLCD/OLED",
            "128x32 GLCD/OLED",
            "192x64 GLCD/OLED",
            "84x48 Nokia5110"});
            this.LcdComBox.Location = new System.Drawing.Point(4, 25);
            this.LcdComBox.Name = "LcdComBox";
            this.LcdComBox.Size = new System.Drawing.Size(229, 28);
            this.LcdComBox.TabIndex = 15;
            this.LcdComBox.Text = "Select LCD";
            this.toolTip.SetToolTip(this.LcdComBox, "Choose GLCD resolution");
            this.LcdComBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Assembler
            // 
            this.Assembler.Controls.Add(this.groupBox2);
            this.Assembler.Controls.Add(this.file_Ext_GB);
            this.Assembler.Location = new System.Drawing.Point(4, 29);
            this.Assembler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Assembler.Name = "Assembler";
            this.Assembler.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Assembler.Size = new System.Drawing.Size(488, 258);
            this.Assembler.TabIndex = 2;
            this.Assembler.Text = "Assembler";
            this.Assembler.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.UseFileNameAsLable_cb);
            this.groupBox2.Controls.Add(this.LableName_tb);
            this.groupBox2.Location = new System.Drawing.Point(9, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(466, 105);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lable name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Lable name:";
            // 
            // UseFileNameAsLable_cb
            // 
            this.UseFileNameAsLable_cb.AutoSize = true;
            this.UseFileNameAsLable_cb.Checked = true;
            this.UseFileNameAsLable_cb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseFileNameAsLable_cb.Location = new System.Drawing.Point(10, 31);
            this.UseFileNameAsLable_cb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UseFileNameAsLable_cb.Name = "UseFileNameAsLable_cb";
            this.UseFileNameAsLable_cb.Size = new System.Drawing.Size(203, 24);
            this.UseFileNameAsLable_cb.TabIndex = 0;
            this.UseFileNameAsLable_cb.Text = "Use file name as a lable";
            this.UseFileNameAsLable_cb.UseVisualStyleBackColor = true;
            this.UseFileNameAsLable_cb.CheckedChanged += new System.EventHandler(this.UseFileNameAsLable_cb_CheckedChanged);
            // 
            // LableName_tb
            // 
            this.LableName_tb.Enabled = false;
            this.LableName_tb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LableName_tb.Location = new System.Drawing.Point(112, 66);
            this.LableName_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LableName_tb.Name = "LableName_tb";
            this.LableName_tb.Size = new System.Drawing.Size(148, 26);
            this.LableName_tb.TabIndex = 12;
            this.LableName_tb.Text = "Lable_name";
            // 
            // file_Ext_GB
            // 
            this.file_Ext_GB.Controls.Add(this.a_File);
            this.file_Ext_GB.Controls.Add(this.asm_File);
            this.file_Ext_GB.Controls.Add(this.inc_File);
            this.file_Ext_GB.Location = new System.Drawing.Point(9, 131);
            this.file_Ext_GB.Name = "file_Ext_GB";
            this.file_Ext_GB.Size = new System.Drawing.Size(153, 114);
            this.file_Ext_GB.TabIndex = 1;
            this.file_Ext_GB.TabStop = false;
            this.file_Ext_GB.Text = "File extension";
            this.toolTip.SetToolTip(this.file_Ext_GB, "Select ASM file extention");
            // 
            // a_File
            // 
            this.a_File.AutoSize = true;
            this.a_File.Location = new System.Drawing.Point(6, 82);
            this.a_File.Name = "a_File";
            this.a_File.Size = new System.Drawing.Size(47, 24);
            this.a_File.TabIndex = 3;
            this.a_File.TabStop = true;
            this.a_File.Text = ".a";
            this.a_File.UseVisualStyleBackColor = true;
            // 
            // asm_File
            // 
            this.asm_File.AutoSize = true;
            this.asm_File.Location = new System.Drawing.Point(6, 52);
            this.asm_File.Name = "asm_File";
            this.asm_File.Size = new System.Drawing.Size(68, 24);
            this.asm_File.TabIndex = 1;
            this.asm_File.Text = ".asm";
            this.asm_File.UseVisualStyleBackColor = true;
            // 
            // inc_File
            // 
            this.inc_File.AutoSize = true;
            this.inc_File.Checked = true;
            this.inc_File.Location = new System.Drawing.Point(4, 25);
            this.inc_File.Name = "inc_File";
            this.inc_File.Size = new System.Drawing.Size(58, 24);
            this.inc_File.TabIndex = 0;
            this.inc_File.TabStop = true;
            this.inc_File.Text = ".inc";
            this.inc_File.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.NumBase);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(488, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "C/C++";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.ArrayNameCB);
            this.groupBox3.Controls.Add(this.ArrayNameTB);
            this.groupBox3.Location = new System.Drawing.Point(9, 9);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(466, 105);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Array name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Array name:";
            // 
            // ArrayNameCB
            // 
            this.ArrayNameCB.AutoSize = true;
            this.ArrayNameCB.Checked = true;
            this.ArrayNameCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ArrayNameCB.Location = new System.Drawing.Point(10, 31);
            this.ArrayNameCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ArrayNameCB.Name = "ArrayNameCB";
            this.ArrayNameCB.Size = new System.Drawing.Size(236, 24);
            this.ArrayNameCB.TabIndex = 0;
            this.ArrayNameCB.Text = "Use file name as array name";
            this.ArrayNameCB.UseVisualStyleBackColor = true;
            this.ArrayNameCB.CheckedChanged += new System.EventHandler(this.ArrayNameCB_CheckedChanged);
            // 
            // ArrayNameTB
            // 
            this.ArrayNameTB.Enabled = false;
            this.ArrayNameTB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ArrayNameTB.Location = new System.Drawing.Point(112, 66);
            this.ArrayNameTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ArrayNameTB.Name = "ArrayNameTB";
            this.ArrayNameTB.Size = new System.Drawing.Size(148, 26);
            this.ArrayNameTB.TabIndex = 12;
            this.ArrayNameTB.Text = "Array_name";
            // 
            // NumBase
            // 
            this.NumBase.Controls.Add(this.Dec_rb);
            this.NumBase.Controls.Add(this.Hex_rb);
            this.NumBase.Location = new System.Drawing.Point(150, 123);
            this.NumBase.Name = "NumBase";
            this.NumBase.Size = new System.Drawing.Size(141, 122);
            this.NumBase.TabIndex = 10;
            this.NumBase.TabStop = false;
            this.NumBase.Text = "Num Base";
            // 
            // Dec_rb
            // 
            this.Dec_rb.AutoSize = true;
            this.Dec_rb.Location = new System.Drawing.Point(4, 58);
            this.Dec_rb.Name = "Dec_rb";
            this.Dec_rb.Size = new System.Drawing.Size(91, 24);
            this.Dec_rb.TabIndex = 1;
            this.Dec_rb.TabStop = true;
            this.Dec_rb.Text = "Decimal";
            this.Dec_rb.UseVisualStyleBackColor = true;
            // 
            // Hex_rb
            // 
            this.Hex_rb.AutoSize = true;
            this.Hex_rb.Checked = true;
            this.Hex_rb.Location = new System.Drawing.Point(4, 31);
            this.Hex_rb.Name = "Hex_rb";
            this.Hex_rb.Size = new System.Drawing.Size(62, 24);
            this.Hex_rb.TabIndex = 0;
            this.Hex_rb.TabStop = true;
            this.Hex_rb.Text = "Hex";
            this.Hex_rb.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cpp_file);
            this.groupBox1.Controls.Add(this.c_file);
            this.groupBox1.Controls.Add(this.c_header);
            this.groupBox1.Location = new System.Drawing.Point(9, 123);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(134, 122);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File extension";
            this.toolTip.SetToolTip(this.groupBox1, "Select C/C++ file extention");
            // 
            // cpp_file
            // 
            this.cpp_file.AutoSize = true;
            this.cpp_file.Location = new System.Drawing.Point(9, 88);
            this.cpp_file.Name = "cpp_file";
            this.cpp_file.Size = new System.Drawing.Size(64, 24);
            this.cpp_file.TabIndex = 2;
            this.cpp_file.TabStop = true;
            this.cpp_file.Text = ".cpp";
            this.cpp_file.UseVisualStyleBackColor = true;
            // 
            // c_file
            // 
            this.c_file.AutoSize = true;
            this.c_file.Location = new System.Drawing.Point(9, 58);
            this.c_file.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c_file.Name = "c_file";
            this.c_file.Size = new System.Drawing.Size(46, 24);
            this.c_file.TabIndex = 1;
            this.c_file.TabStop = true;
            this.c_file.Text = ".c";
            this.c_file.UseVisualStyleBackColor = true;
            // 
            // c_header
            // 
            this.c_header.AutoSize = true;
            this.c_header.Checked = true;
            this.c_header.Location = new System.Drawing.Point(9, 31);
            this.c_header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c_header.Name = "c_header";
            this.c_header.Size = new System.Drawing.Size(47, 24);
            this.c_header.TabIndex = 0;
            this.c_header.TabStop = true;
            this.c_header.Text = ".h";
            this.c_header.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.ROM_Addr_tb);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.ProgramMemCk);
            this.tabPage1.Controls.Add(this.HeaderCB);
            this.tabPage1.Controls.Add(this.OutputGB);
            this.tabPage1.Controls.Add(this.RLEcompressionCB);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(488, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Misc";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.MonoRb);
            this.groupBox9.Controls.Add(this.ColorRb);
            this.groupBox9.Location = new System.Drawing.Point(320, 148);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox9.Size = new System.Drawing.Size(135, 94);
            this.groupBox9.TabIndex = 21;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Image Grid";
            // 
            // MonoRb
            // 
            this.MonoRb.AutoSize = true;
            this.MonoRb.Checked = true;
            this.MonoRb.Location = new System.Drawing.Point(10, 58);
            this.MonoRb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MonoRb.Name = "MonoRb";
            this.MonoRb.Size = new System.Drawing.Size(74, 24);
            this.MonoRb.TabIndex = 1;
            this.MonoRb.TabStop = true;
            this.MonoRb.Text = "Mono";
            this.MonoRb.UseVisualStyleBackColor = true;
            // 
            // ColorRb
            // 
            this.ColorRb.AutoSize = true;
            this.ColorRb.Location = new System.Drawing.Point(10, 31);
            this.ColorRb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ColorRb.Name = "ColorRb";
            this.ColorRb.Size = new System.Drawing.Size(71, 24);
            this.ColorRb.TabIndex = 0;
            this.ColorRb.Text = "Color";
            this.ColorRb.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.BytesPerLineCB);
            this.groupBox8.Location = new System.Drawing.Point(298, 9);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(162, 62);
            this.groupBox8.TabIndex = 20;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Bytes Per Raw";
            // 
            // BytesPerLineCB
            // 
            this.BytesPerLineCB.FormattingEnabled = true;
            this.BytesPerLineCB.Items.AddRange(new object[] {
            "8 Bytes/Raw",
            "16 Bytes/Raw",
            "32 Bytes/Raw",
            "64 Bytes/Raw"});
            this.BytesPerLineCB.Location = new System.Drawing.Point(6, 25);
            this.BytesPerLineCB.Name = "BytesPerLineCB";
            this.BytesPerLineCB.Size = new System.Drawing.Size(148, 28);
            this.BytesPerLineCB.TabIndex = 19;
            this.BytesPerLineCB.Text = "Bytes Per Raw";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.horizontalRB);
            this.groupBox6.Controls.Add(this.verticalRB);
            this.groupBox6.Location = new System.Drawing.Point(159, 148);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(152, 95);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Byte orientaion";
            // 
            // horizontalRB
            // 
            this.horizontalRB.AutoSize = true;
            this.horizontalRB.Location = new System.Drawing.Point(6, 58);
            this.horizontalRB.Name = "horizontalRB";
            this.horizontalRB.Size = new System.Drawing.Size(106, 24);
            this.horizontalRB.TabIndex = 1;
            this.horizontalRB.Text = "Horizontal";
            this.horizontalRB.UseVisualStyleBackColor = true;
            // 
            // verticalRB
            // 
            this.verticalRB.AutoSize = true;
            this.verticalRB.Checked = true;
            this.verticalRB.Location = new System.Drawing.Point(6, 31);
            this.verticalRB.Name = "verticalRB";
            this.verticalRB.Size = new System.Drawing.Size(87, 24);
            this.verticalRB.TabIndex = 0;
            this.verticalRB.TabStop = true;
            this.verticalRB.Text = "Vertical";
            this.verticalRB.UseVisualStyleBackColor = true;
            // 
            // ROM_Addr_tb
            // 
            this.ROM_Addr_tb.Enabled = false;
            this.ROM_Addr_tb.Location = new System.Drawing.Point(159, 114);
            this.ROM_Addr_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ROM_Addr_tb.Name = "ROM_Addr_tb";
            this.ROM_Addr_tb.Size = new System.Drawing.Size(150, 26);
            this.ROM_Addr_tb.TabIndex = 17;
            this.ROM_Addr_tb.Text = "ROM Address";
            this.toolTip.SetToolTip(this.ROM_Addr_tb, "EEPROM Address to place the DATA in");
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.AVR_rb);
            this.groupBox7.Controls.Add(this.PIC_rb);
            this.groupBox7.Location = new System.Drawing.Point(9, 148);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Size = new System.Drawing.Size(142, 95);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Microcontroller";
            // 
            // AVR_rb
            // 
            this.AVR_rb.AutoSize = true;
            this.AVR_rb.Checked = true;
            this.AVR_rb.Location = new System.Drawing.Point(10, 31);
            this.AVR_rb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AVR_rb.Name = "AVR_rb";
            this.AVR_rb.Size = new System.Drawing.Size(113, 24);
            this.AVR_rb.TabIndex = 0;
            this.AVR_rb.TabStop = true;
            this.AVR_rb.Text = "Atmel AVR";
            this.AVR_rb.UseVisualStyleBackColor = true;
            this.AVR_rb.CheckedChanged += new System.EventHandler(this.AVR_rb_CheckedChanged);
            // 
            // PIC_rb
            // 
            this.PIC_rb.AutoSize = true;
            this.PIC_rb.Location = new System.Drawing.Point(10, 58);
            this.PIC_rb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PIC_rb.Name = "PIC_rb";
            this.PIC_rb.Size = new System.Drawing.Size(131, 24);
            this.PIC_rb.TabIndex = 1;
            this.PIC_rb.Text = "Microchip PIC";
            this.PIC_rb.UseVisualStyleBackColor = true;
            this.PIC_rb.CheckedChanged += new System.EventHandler(this.PIC_rb_CheckedChanged);
            // 
            // ProgramMemCk
            // 
            this.ProgramMemCk.AutoSize = true;
            this.ProgramMemCk.Location = new System.Drawing.Point(159, 42);
            this.ProgramMemCk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProgramMemCk.Name = "ProgramMemCk";
            this.ProgramMemCk.Size = new System.Drawing.Size(104, 24);
            this.ProgramMemCk.TabIndex = 15;
            this.ProgramMemCk.Text = "EEPROM";
            this.toolTip.SetToolTip(this.ProgramMemCk, "Place the array in ROM memory");
            this.ProgramMemCk.UseVisualStyleBackColor = true;
            this.ProgramMemCk.CheckedChanged += new System.EventHandler(this.ProgramMemCk_CheckedChanged);
            // 
            // HeaderCB
            // 
            this.HeaderCB.AutoSize = true;
            this.HeaderCB.Checked = true;
            this.HeaderCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HeaderCB.Location = new System.Drawing.Point(159, 74);
            this.HeaderCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HeaderCB.Name = "HeaderCB";
            this.HeaderCB.Size = new System.Drawing.Size(88, 24);
            this.HeaderCB.TabIndex = 14;
            this.HeaderCB.Text = "Header";
            this.toolTip.SetToolTip(this.HeaderCB, "Adds a header with information about the Image array");
            this.HeaderCB.UseVisualStyleBackColor = true;
            // 
            // OutputGB
            // 
            this.OutputGB.Controls.Add(this.ASM_rb);
            this.OutputGB.Controls.Add(this.Binary_rb);
            this.OutputGB.Controls.Add(this.C_rb);
            this.OutputGB.Location = new System.Drawing.Point(9, 9);
            this.OutputGB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OutputGB.Name = "OutputGB";
            this.OutputGB.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OutputGB.Size = new System.Drawing.Size(142, 129);
            this.OutputGB.TabIndex = 10;
            this.OutputGB.TabStop = false;
            this.OutputGB.Text = "Output";
            // 
            // ASM_rb
            // 
            this.ASM_rb.AutoSize = true;
            this.ASM_rb.Location = new System.Drawing.Point(9, 63);
            this.ASM_rb.Name = "ASM_rb";
            this.ASM_rb.Size = new System.Drawing.Size(109, 24);
            this.ASM_rb.TabIndex = 1;
            this.ASM_rb.TabStop = true;
            this.ASM_rb.Text = "Assembler";
            this.toolTip.SetToolTip(this.ASM_rb, "Output Assembly Image DATA block");
            this.ASM_rb.UseVisualStyleBackColor = true;
            // 
            // Binary_rb
            // 
            this.Binary_rb.AutoSize = true;
            this.Binary_rb.Location = new System.Drawing.Point(9, 94);
            this.Binary_rb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Binary_rb.Name = "Binary_rb";
            this.Binary_rb.Size = new System.Drawing.Size(78, 24);
            this.Binary_rb.TabIndex = 2;
            this.Binary_rb.TabStop = true;
            this.Binary_rb.Text = "Binary";
            this.toolTip.SetToolTip(this.Binary_rb, "Output a binary Raw file");
            this.Binary_rb.UseVisualStyleBackColor = true;
            this.Binary_rb.CheckedChanged += new System.EventHandler(this.Binary_rb_CheckedChanged);
            // 
            // C_rb
            // 
            this.C_rb.AutoSize = true;
            this.C_rb.Checked = true;
            this.C_rb.Location = new System.Drawing.Point(9, 32);
            this.C_rb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.C_rb.Name = "C_rb";
            this.C_rb.Size = new System.Drawing.Size(78, 24);
            this.C_rb.TabIndex = 0;
            this.C_rb.TabStop = true;
            this.C_rb.Text = "C++/C";
            this.toolTip.SetToolTip(this.C_rb, "Output an C/C++ ARRAY with the Image data");
            this.C_rb.UseVisualStyleBackColor = true;
            this.C_rb.CheckedChanged += new System.EventHandler(this.C_rb_CheckedChanged);
            // 
            // RLEcompressionCB
            // 
            this.RLEcompressionCB.AccessibleDescription = "";
            this.RLEcompressionCB.AutoSize = true;
            this.RLEcompressionCB.Location = new System.Drawing.Point(159, 9);
            this.RLEcompressionCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RLEcompressionCB.Name = "RLEcompressionCB";
            this.RLEcompressionCB.Size = new System.Drawing.Size(67, 24);
            this.RLEcompressionCB.TabIndex = 7;
            this.RLEcompressionCB.Text = "RLE";
            this.toolTip.SetToolTip(this.RLEcompressionCB, "Compress the Image data");
            this.RLEcompressionCB.UseVisualStyleBackColor = true;
            this.RLEcompressionCB.CheckedChanged += new System.EventHandler(this.RLEcompressionCB_CheckedChanged);
            // 
            // SettingsTabs
            // 
            this.SettingsTabs.Controls.Add(this.tabPage1);
            this.SettingsTabs.Controls.Add(this.tabPage2);
            this.SettingsTabs.Controls.Add(this.Assembler);
            this.SettingsTabs.Controls.Add(this.Resolution);
            this.SettingsTabs.Controls.Add(this.Screen);
            this.SettingsTabs.Location = new System.Drawing.Point(18, 18);
            this.SettingsTabs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SettingsTabs.Name = "SettingsTabs";
            this.SettingsTabs.SelectedIndex = 0;
            this.SettingsTabs.Size = new System.Drawing.Size(496, 291);
            this.SettingsTabs.TabIndex = 6;
            // 
            // Screen
            // 
            this.Screen.Controls.Add(this.groupBox10);
            this.Screen.Location = new System.Drawing.Point(4, 29);
            this.Screen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Screen.Name = "Screen";
            this.Screen.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Screen.Size = new System.Drawing.Size(488, 258);
            this.Screen.TabIndex = 3;
            this.Screen.Text = "Nokia5110";
            this.Screen.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.radioButton2);
            this.groupBox10.Controls.Add(this.radioButton1);
            this.groupBox10.Location = new System.Drawing.Point(10, 11);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox10.Size = new System.Drawing.Size(176, 106);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Addressing Mode";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 66);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Vertical";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 31);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hrozontal";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 366);
            this.Controls.Add(this.SettingsTabs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OKBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Resolution.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.Assembler.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.file_Ext_GB.ResumeLayout(false);
            this.file_Ext_GB.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.NumBase.ResumeLayout(false);
            this.NumBase.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.OutputGB.ResumeLayout(false);
            this.OutputGB.PerformLayout();
            this.SettingsTabs.ResumeLayout(false);
            this.Screen.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage Resolution;
        private System.Windows.Forms.GroupBox groupBox5;
        protected internal System.Windows.Forms.TextBox hightTB;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox WidthTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.ComboBox LcdComBox;
        private System.Windows.Forms.TabPage Assembler;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton c_file;
        public System.Windows.Forms.RadioButton c_header;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox OutputGB;
        private System.Windows.Forms.GroupBox file_Ext_GB;
        private System.Windows.Forms.RadioButton cpp_file;
        private System.Windows.Forms.RadioButton ASM_rb;
        public System.Windows.Forms.TabControl SettingsTabs;
        private System.Windows.Forms.GroupBox NumBase;
        private System.Windows.Forms.RadioButton Dec_rb;
        private System.Windows.Forms.RadioButton Hex_rb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.CheckBox UseFileNameAsLable_cb;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton PIC_rb;
        private System.Windows.Forms.RadioButton Binary_rb;
        private System.Windows.Forms.RadioButton C_rb;
        private System.Windows.Forms.CheckBox ProgramMemCk;
        private System.Windows.Forms.CheckBox RLEcompressionCB;
        private System.Windows.Forms.CheckBox HeaderCB;
        private System.Windows.Forms.RadioButton asm_File;
        private System.Windows.Forms.RadioButton inc_File;
        private System.Windows.Forms.RadioButton a_File;
        private System.Windows.Forms.RadioButton AVR_rb;
        private System.Windows.Forms.CheckBox ArrayNameCB;
        private System.Windows.Forms.TextBox ArrayNameTB;
        private System.Windows.Forms.TextBox ROM_Addr_tb;
        private System.Windows.Forms.TextBox LableName_tb;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton horizontalRB;
        private System.Windows.Forms.RadioButton verticalRB;
        private System.Windows.Forms.GroupBox groupBox8;
        public System.Windows.Forms.ComboBox BytesPerLineCB;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton MonoRb;
        private System.Windows.Forms.RadioButton ColorRb;
        private System.Windows.Forms.TabPage Screen;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }

}