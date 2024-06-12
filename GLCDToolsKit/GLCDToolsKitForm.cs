//#define SERIALKEY

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Permissions;
using Microsoft.Win32;
using System.Drawing.Imaging;
using System.Windows.Forms.VisualStyles;
using System.Threading;


namespace GLCDToolsKit
{
    public partial class GLCDToolsKitForm : Form
    {
        Settings settings = new Settings();
        static ImgInfo imginfo = new ImgInfo();
        static Pallete pallete = new Pallete(image);
        static Image image = new Image(imginfo, pallete);
        static Color BackgroundColor = new Color();
        SKGL.Validate skgl = new SKGL.Validate();

        RegistryKey glcdkey;


        public GLCDToolsKitForm()
        {
            InitializeComponent();
            // read settings from registry
            //RegistryKeyPermissionCheck regcheck = RegistryKeyPermissionCheck.ReadWriteSubTree;
            glcdkey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\GLCD Tollskit");
            // SetStyle (ControlStyles.OptimizedDoubleBuffer, true);
            //SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            


#if SERIALKEY
            try
            {
                String SerialKey = glcdkey.GetValue("Serial Key").ToString();

                String Password = glcdkey.GetValue("Password").ToString();

                

                skgl.Key = SerialKey;
                skgl.secretPhase = Password;

                //if (!skgl.IsValid)
                //{
                //    DialogResult DialogResult = MessageBox.Show("Your Serial Key is not valid, Woul'd you like to register?", "InValid Serial Key", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                //}
                //else if (skgl.DaysLeft < 0)
                //{
                //    
                //}
            }
            catch (NullReferenceException)
            {
                //MessageBox.Show("You need to register in order to fully enjoy this software", "UnRegistered Version");
                // Not registered TURN-ON RegisterationTimer to popup registeration MessageBox in a few seconds endless loop
                RegistrationTimer.Enabled = true;

            }
#endif
            try {
                settings.RLECompress = Convert.ToBoolean(this.glcdkey.GetValue("RLE Compression"));
                settings.PutDataInROM = Convert.ToBoolean(this.glcdkey.GetValue("Put data in ROM"));
                settings.MicrocontrollerToUse = (Settings.MicrocontrollerType)this.glcdkey.GetValue("Microcontroller");
                settings.DataStructureFormat = (Settings.LanguageFormat)this.glcdkey.GetValue("Data Structure Format");
                settings.CFileExtention = (Settings.CFileExtentionType)this.glcdkey.GetValue("C File Extention");
                settings.UseFileNameAsArrayName = Convert.ToBoolean(this.glcdkey.GetValue("Use filename As Array name"));
                settings.ArrayName = (string)this.glcdkey.GetValue("Array Name");
                settings.AddHeader = Convert.ToBoolean(this.glcdkey.GetValue("Header"));
                settings.WidthTB.Text = Convert.ToString(this.glcdkey.GetValue("Width Resolution"));
                settings.hightTB.Text = Convert.ToString(this.glcdkey.GetValue("Hight Resolution"));
                settings.LcdComBox.SelectedIndex = (int)this.glcdkey.GetValue("LCD Type");
                settings.AsmFileExtention = (Settings.AsmFileExtentionType)this.glcdkey.GetValue("ASM File Extention");
                settings.NumBaseToUse = (Settings.NumberBase)this.glcdkey.GetValue("Number Base To Use");
                settings.UseFileNameAsLable = Convert.ToBoolean(this.glcdkey.GetValue("Use File Name As Lable"));
                settings.ROMAddress = Convert.ToString(this.glcdkey.GetValue("Rom Address"));
                settings.ByteOrientation = (Settings.Orientation)this.glcdkey.GetValue("Byte Orientation");
                settings.BytesPerLineCB.SelectedIndex = (int)this.glcdkey.GetValue("Bytes Per Raw");
                settings.ImageGrixColors = (Image.ImageDisplayEnum)glcdkey.GetValue("Image Grid Colors");
            }

            catch (NullReferenceException)
            {
                glcdkey.SetValue("Test", (object)true, RegistryValueKind.DWord);
                glcdkey.SetValue("RLE Compression", (object)this.settings.RLECompress);
                glcdkey.SetValue("Microcontroller", (object)this.settings.MicrocontrollerToUse, RegistryValueKind.DWord);
                glcdkey.SetValue("Data Structure Format", (object)this.settings.DataStructureFormat, RegistryValueKind.DWord);
                glcdkey.SetValue("Put data in ROM", (object)this.settings.PutDataInROM);
                glcdkey.SetValue("C File Extention", (object)this.settings.CFileExtention, RegistryValueKind.DWord);
                glcdkey.SetValue("Use filename As Array name", (object)true);
                glcdkey.SetValue("Use File Name As Lable", (object)true);
                glcdkey.SetValue("Array Name", (object)"Array_Name", RegistryValueKind.String);
                glcdkey.SetValue("Header", (object)true);
                glcdkey.SetValue("LCD Type", (object)0, RegistryValueKind.DWord);
                glcdkey.SetValue("Width Resolution", (object)128);
                glcdkey.SetValue("Hight Resolution", (object)64);
                glcdkey.SetValue("ASM File Extention", (object)this.settings.AsmFileExtention, RegistryValueKind.DWord);
                glcdkey.SetValue("Number Base To Use", (object)this.settings.NumBaseToUse, RegistryValueKind.DWord);
                glcdkey.SetValue("Rom Address", (object)this.settings.ROMAddress);
                glcdkey.SetValue("Byte Orientation", (object)this.settings.ByteOrientation, RegistryValueKind.DWord);
                glcdkey.SetValue("Bytes Per Raw", (object)this.settings.BytesPerLineCB.SelectedIndex, RegistryValueKind.DWord);
                glcdkey.SetValue("Image Grid Colors", settings.ImageGrixColors, RegistryValueKind.DWord);
            };

            Output_sl.Text = "Output: " + settings.DataStructureFormat.ToString();
            FileExt_sl.Text = "File Ext: " + settings.GetFileExtentionString;
            Compression_sl.Text = "Compression: " + (settings.RLECompress ? "ON" : "OFF");
            sizeStatusLabel.Text = "Size: " + settings.WidthTB.Text + "x" +settings.hightTB.Text;

        }

        private void RegistrationTimer_Tick(object sender, EventArgs e)
        {
            ((System.Windows.Forms.Timer)sender).Enabled = false;

            if (MessageBox.Show("Please consider Registering the software to support future upgrades.","Registration Message",MessageBoxButtons.OK,MessageBoxIcon.Asterisk) == DialogResult.OK)
                ((System.Windows.Forms.Timer)sender).Enabled = true;

        }

        // load image file...
        private void LoadImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            Graphics gfx = this.CreateGraphics();


            dlg.Filter = "All Images (*.PNG,*.BMP,*.GIF,*.JPEG)|*.png;*.bmp;*.gif;*.jpeg|Bitmap (*.BMP)|*.bmp|PNG (*.PNG)|*.png|GIF (*.GIF)|*.gif|JPEG (*.JPEG)|*.jpeg|All (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Filename_tb.Text = dlg.SafeFileName;

                glcdkey.SetValue("Path", dlg.FileName.Substring(0, dlg.FileName.Length - dlg.SafeFileName.Length));

                gfx.Clear(Color.White);
                Bitmap tempBitmap = new Bitmap(dlg.FileName);

                // Check if image is whithin size limits
                if (tempBitmap.Width <= Convert.ToByte(settings.WidthTB.Text) && tempBitmap.Height <= Convert.ToByte(settings.hightTB.Text))
                {
                    if (image.bitmap != null)
                    {
                        image.bitmap.Dispose();
                        image.bitmap = null;
                    }
                    
                    image.bitmap = tempBitmap;
                   

                    SetStatusbarBpp();

                    if (settings.ImageGrixColors == Image.ImageDisplayEnum.Color)
                        image.DrawColoredPixeled(CreateGraphics(), this,(Width - (image.bitmap.Width * 5)) / 2, (Height - (image.bitmap.Height * 5)) / 2);
                    else
                        image.DrawPixeled(CreateGraphics(), this,(Width - (image.bitmap.Width * 5)) / 2, (Height - (image.bitmap.Height * 5)) / 2);

                    if (image.IsIndexed())
                    {
                        PalleteMenu.Enabled = true;
                        convertToMonoToolStripMenuItem.Enabled = false;
                        Indexed_s1.Text = "Indexed: Yes";
                    }
                    else
                    {
                        PalleteMenu.Enabled = false;
                        convertToMonoToolStripMenuItem.Enabled = true;
                        Indexed_s1.Text = "Indexed: No";

                    }
                    Convert_btn.Enabled = true;
                    saveCFileToolSMenuItem.Enabled = true;
                    imginfo.SetImage(image);
                    imageInformationToolStripMenuItem.Enabled = true;
                    toolStripStatusLabel1.Text = "Select the Image background color";
                }
                else
                {
                    MessageBox.Show("Image file is bigger then " + settings.WidthTB.Text + "x" + settings.hightTB.Text, "Image file Error");
                    Convert_btn.Enabled = false;
                    toolStripStatusLabel1.Text = "Select Another Image file for convertion to GLCD format";
                }

            }
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            bool success = false;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "C Source Code|*.c|Asm Source COde|*.s;*.a|Binary File|*.bin";


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        success = generateCfile();
                        break;
                    case 2:
                        success = generateAsmFile();
                        break;
                    case 3:
                        success = generateBinFile();
                        break;
                }
            }

            if (success)
                MessageBox.Show("File was converted and Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        // the image is build from memory orgenized byte after byte, arranged horizontally in memory.
        // this function reads byte Vertical byte from memory in location x,page;
        private byte verticalByte(byte X, byte page)
        {
            Color TmpColor;
            byte pixel = 0;

            for (byte y = 0; y < 8; y++)
            {
                TmpColor = image.bitmap.GetPixel(X, (page * 8) + y);
                if (!compareRGB(TmpColor, BGColorButton.BackColor))
                    pixel |= (byte)(1 << y);
            }

            return pixel;
        }

        private bool compareRGB(Color Color, Color color2)
        {
            if (Color.R == color2.R && Color.G == color2.G && Color.B == color2.B)
                return true;
            else
                return false;
        }

        private void colorPalleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (pallete.ShowDialog(this) == DialogResult.OK)
            {
                BGColorButton.BackColor = pallete.selectedColor;

                if (image.bitmap != null)
                    image.DrawPixeled(CreateGraphics(), this,(Width - (image.bitmap.Width * 5)) / 2, (Height - (image.bitmap.Height * 5)) / 2);
            }
            //pallete.Colors.Controls[0];
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadImageBtn_Click(this, EventArgs.Empty);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Color PickedColor;
            PickedColor = image.bitmap.GetPixel(e.Location.X, e.Location.Y);

            BGColorButton.BackColor = colorDialog1.Color = PickedColor;
        }

        private void aboutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();


            frm.Show();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.ShowDialog() == DialogResult.OK)
            {
                Output_sl.Text = "Output: " + settings.DataStructureFormat.ToString();
                FileExt_sl.Text = "File Ext: " + settings.GetFileExtentionString;
                Compression_sl.Text = "Compression: " + (settings.RLECompress ? "ON" : "OFF");
                sizeStatusLabel.Text = "Size: " + settings.WidthTB.Text + "x" + settings.hightTB.Text;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            List<Color> getImageColors = image.GetImageColors;
            Graphics graphics = this.CreateGraphics();
            colorDialog1.AllowFullOpen = true;

            int[] ColorsArray = new int[getImageColors.Count];
            Color Color;

            for (int i = 0; i < getImageColors.Count; i++)
            {
                Color = getImageColors.ElementAt(i);
                int Blue = Color.B << 16;
                int Green = (int)Color.G << 8;
                int Red = (int)Color.R;
                int BGRColor = Blue | Green | Red;

                ColorsArray[i] = BGRColor;
            }

            colorDialog1.CustomColors = ColorsArray;
            if (PalleteMenu.Enabled)
            {
                if (pallete.ShowDialog() == DialogResult.OK)
                {                  
                    image.BackgroundColor = BGColorButton.BackColor = Color = pallete.selectedColor;
                    if (image.bitmap != null)
                        image.DrawPixeled(graphics, this, (Width - GLCDToolsKitForm.image.bitmap.Width * 5) / 2, (Height - GLCDToolsKitForm.image.bitmap.Height * 5) / 2);
                }
            }
            else if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                image.BackgroundColor = BGColorButton.BackColor = Color = this.colorDialog1.Color;

                if (image.bitmap != null)
                    image.DrawPixeled(graphics, this, (Width - GLCDToolsKitForm.image.bitmap.Width * 5) / 2, (Height - GLCDToolsKitForm.image.bitmap.Height * 5) / 2);
            }
            toolStripStatusLabel1.Text = "Background color has been changed...";
        }


        private void imageInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imginfo.ShowDialog();
        }

        private void RLECompressAndCconvert(StreamWriter stream)
        {
            byte BytesPerLine = 0;
            int TotalBytes = 0;
            byte Counter = 0;
            if (settings.DataStructureFormat == Settings.LanguageFormat.Asm)
            {
                stream.WriteLine(GetAsmLable + ":");
                stream.Write(settings.AssemblerDirective);
            }
            byte ByteToCount;
            if (settings.ByteOrientation == Settings.Orientation.Vertical)
            {
                ByteToCount = image.VerticalByte(0, 0);
                for (byte page = 0; page < image.bitmap.Height / 8; ++page)
                {
                    for (byte X = 0; X < image.bitmap.Width; ++X)
                    {
                        byte VerticalByte;
                        if ((int)(VerticalByte = image.VerticalByte(X, page)) == ByteToCount)
                        {
                            ++Counter;
                        }
                        else
                        {
                            if (settings.DataStructureFormat == Settings.LanguageFormat.C)
                                stream.Write("0x{0:X2},0x{1:X2},", Counter, ByteToCount);
                            else if (settings.DataStructureFormat == Settings.LanguageFormat.Asm)
                                stream.Write("{0:X2},{1:X2},", Counter, ByteToCount);

                            Counter = 1;
                            ByteToCount = VerticalByte;
                            TotalBytes += 2;
                            BytesPerLine += 2;

                            if (BytesPerLine == 16)
                            {
                                stream.WriteLine();
                                if (settings.DataStructureFormat == Settings.LanguageFormat.Asm)
                                    stream.Write(settings.AssemblerDirective);
                                BytesPerLine = 0;
                            }
                        }
                    }
                }
            }
            else
            {
                ByteToCount = image.HorizontalByte((byte)0, (byte)0);
                for (byte Ypos = 0; Ypos < image.bitmap.Height; ++Ypos)
                {
                    for (byte Xpos = 0; Xpos < image.bitmap.Width / 8; ++Xpos)
                    {
                        byte HorizontalByte;
                        if ((int)(HorizontalByte = image.HorizontalByte(Xpos, Ypos)) == ByteToCount)
                        {
                            ++Counter;
                        }
                        else
                        {
                            if (settings.DataStructureFormat == Settings.LanguageFormat.C)
                                stream.Write("0x{0:X2},0x{1:X2},", Counter, ByteToCount);
                            else if (settings.DataStructureFormat == Settings.LanguageFormat.Asm)
                                stream.Write("{0:X2},{1:X2},", Counter, ByteToCount);

                            Counter = 1;
                            ByteToCount = HorizontalByte;
                            TotalBytes += 2;
                            BytesPerLine += 2;

                            if (BytesPerLine == 16)
                            {
                                stream.WriteLine();
                                if (this.settings.DataStructureFormat == Settings.LanguageFormat.Asm)
                                    stream.Write(this.settings.AssemblerDirective);
                                BytesPerLine = (byte)0;
                            }
                        }
                    }
                }
            }
            if (settings.DataStructureFormat == Settings.LanguageFormat.C)
                stream.Write("0x{0:X2},0x{1:X2}", Counter, ByteToCount);
            else if (settings.DataStructureFormat == Settings.LanguageFormat.Asm)
                stream.Write("{0:X2},{1:X2}", Counter, ByteToCount);

            TotalBytes +=2;

            if (settings.DataStructureFormat == Settings.LanguageFormat.C)
            {
                stream.Write("};");
                if (settings.AddHeader)
                {
                    stream.WriteLine("\r\n\r\n");
                    stream.WriteLine("struct header_t {");
                    stream.WriteLine("  unsigned char Width = {0}, Hight = {1};", (object)GLCDToolsKitForm.image.bitmap.Width, (object)GLCDToolsKitForm.image.bitmap.Height);
                    stream.WriteLine("  unsigned int RleLength = {0}", TotalBytes);
                    stream.WriteLine("} header;");
                }
            }
        }

        private void RLECompressAndCconvertToBin(FileStream stream)
        {
            byte Counter = 0;
            byte ByteToCount;

            if (settings.ByteOrientation == Settings.Orientation.Vertical)
            {
                ByteToCount = image.VerticalByte(0, 0);
                for (byte page = 0; page < image.bitmap.Height / 8; ++page)
                {
                    for (byte X = 0; X < image.bitmap.Width; ++X)
                    {
                        byte VerticalByte;
                        if ((VerticalByte = image.VerticalByte(X, page)) == ByteToCount)
                        {
                            ++Counter;
                        }
                        else
                        {
                            stream.WriteByte(Counter);
                            stream.WriteByte(ByteToCount);
                            Counter = 1;
                            ByteToCount = VerticalByte;
                        }
                    }
                }
            }
            else
            {
                ByteToCount = image.HorizontalByte(0, 0);
                for (byte Ypos = 0; Ypos < image.bitmap.Height; ++Ypos)
                {
                    for (byte Xpos = 0; Xpos < image.bitmap.Width / 8; ++Xpos)
                    {
                        byte HorizontalByte;
                        if ((HorizontalByte = image.HorizontalByte(Xpos, Ypos)) == ByteToCount)
                        {
                            ++Counter;
                        }
                        else
                        {
                            stream.WriteByte(Counter);
                            stream.WriteByte(ByteToCount);
                            Counter = (byte)1;
                            ByteToCount = HorizontalByte;
                        }
                    }
                }
            }
            stream.WriteByte(Counter);
            stream.WriteByte(ByteToCount);
        }


        private void C_ConvertToFile(StreamWriter stream)
        {
            if (settings.ByteOrientation == Settings.Orientation.Vertical)
            {
                for (byte page = 0; page < image.bitmap.Height / 8; ++page)
                {
                    stream.WriteLine("//page {0}", (object)page);
                    byte BytesPerLine = 0;
                    for (byte X = 0; X < image.bitmap.Width; ++X)
                    {
                        if (settings.NumBaseToUse == Settings.NumberBase.Hex)
                            stream.Write("0x{0:X2}", image.VerticalByte(X, page));
                        else
                            stream.Write(image.VerticalByte(X, page));
                        if (page == image.bitmap.Height / 8 - 1 && X == image.bitmap.Width - 1)
                        {
                            stream.WriteLine();
                            stream.Write("};");
                        }
                        else
                            stream.Write(",");
                        if (++BytesPerLine == settings.BytesPerRaw)
                        {
                            stream.WriteLine();
                            BytesPerLine = 0;
                        }
                    }
                    stream.WriteLine();
                }
            }
            else
            {
                byte BytesPerLine = 0;
                for (byte Ypos = 0; Ypos < image.bitmap.Height; ++Ypos)
                {
                    for (byte Xpos = 0; Xpos < image.bitmap.Width / 8; ++Xpos)
                    {
                        if (settings.NumBaseToUse == Settings.NumberBase.Hex)
                            stream.Write("0x{0:X2}", image.HorizontalByte(Xpos, Ypos));
                        else
                            stream.Write(image.HorizontalByte(Xpos, Ypos));
                        if (Ypos == image.bitmap.Height - 1 && Xpos == image.bitmap.Width / 8 - 1)
                        {
                            stream.WriteLine();
                            stream.Write("};");
                        }
                        else
                            stream.Write(",");
                        if (++BytesPerLine == settings.BytesPerRaw)
                        {
                            stream.WriteLine();
                            BytesPerLine = 0;
                        }
                    }
                }
            }
        }

        private void Asm_ConvertToFile(StreamWriter stream)
        {
            if (settings.PutDataInROM)
                stream.WriteLine(".ESEG");

            byte BytesPerLine = 0;
            if (settings.ByteOrientation == Settings.Orientation.Vertical)
            {
                for (byte page = 0; page < image.bitmap.Height / 8; page++)
                {
                    stream.WriteLine(";page {0}", page);
                    stream.Write(settings.AssemblerDirective);
                    for (byte X = 0; X < image.bitmap.Width; X++)
                    {
                        stream.Write("{0:X2}", image.VerticalByte(X, page));
                        if (++BytesPerLine == settings.BytesPerRaw)
                        {
                            stream.WriteLine();

                            if (X < image.bitmap.Width - 1)
                                stream.Write(settings.AssemblerDirective);

                            BytesPerLine = 0;
                        }
                        else
                            stream.Write(",");
                    }
                    stream.WriteLine();
                }
            }
            else
            {
                stream.Write(settings.AssemblerDirective);
                for (byte Ypos = 0; Ypos < image.bitmap.Height; Ypos++)
                {
                    for (byte Xpos = 0; Xpos < image.bitmap.Width / 8; Xpos++)
                    {
                        stream.Write("{0:X2}", image.HorizontalByte(Xpos, Ypos));
                        if (++BytesPerLine == settings.BytesPerRaw)
                        {
                            stream.WriteLine();
                            if (Ypos != image.bitmap.Height - 1 || Xpos != image.bitmap.Width / 8 - 1)
                                stream.Write(settings.AssemblerDirective);
                            BytesPerLine = 0;
                        }
                        else
                            stream.Write(",");
                    }
                }
            }
        }


        // write to file as a raw binary format
        private void Bin_ConvertToFile(FileStream stream)
        {
            if (settings.ByteOrientation == Settings.Orientation.Vertical)
            {

                for (byte page = 0; page < (image.bitmap.Height / 8); page++)
                {


                    for (byte X = 0; X < image.bitmap.Width; X++)                                     // go over a line of pixels and convert them...
                        stream.WriteByte(image.VerticalByte(X, page));
                }
            }
            else
            {
                for (byte Ypos = 0; Ypos< image.bitmap.Height; Ypos++)
                {


                    for (byte Xpos = 0; Xpos<image.bitmap.Width/8; Xpos++)                                     // go over a line of pixels and convert them...
                        stream.WriteByte(image.HorizontalByte(Xpos, Ypos));
                }
            }

        }

        // draw the image as a grid
        private void drawGrid(int PosX,int PosY)
        {
            Graphics gfx = this.CreateGraphics();
            Pen pen = new Pen(Color.Black, 1);

            for (byte y = 0; y < 65; y++)
            {
                // lines
                gfx.DrawLine (pen,new Point (PosX,PosY+y*5),new Point (PosX+128*5,PosY+y*5));
 
            }

            for (byte x=0;x <129;x++)
                gfx.DrawLine(pen, new Point(PosX+x*5, PosY), new Point(PosX+x*5, PosY + 64*5));
        }

   
        private void ConvertToMonochrome()
        {
            progressBar.Value = 0;
            progressBar.Maximum = image.bitmap.Height-1;

            for (byte x = 0; x < image.bitmap.Width; x++)
                for (byte y = 0; y < image.bitmap.Height; y++)
                {
                    if (image.bitmap.GetPixel(x, y).ToArgb() != image.BackgroundColor.ToArgb())
                        image.bitmap.SetPixel(x, y, Color.Black);

                    progressBar.Value = y;
                }

            MessageBox.Show("Conversion to monochrome successfully finished!");
            progressBar.Value = 0;
        }

        private void convertToMonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertToMonochrome(); 
        }

     

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void saveSourceFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertBtn_Click(this, EventArgs.Empty);
        }

        private Boolean generateCfile()
        {
            StreamWriter stream;
            SaveFileDialog Sdlg = new SaveFileDialog();

            bool success = false;

            Sdlg.Filter = settings.CFileFilter;


            if (Sdlg.ShowDialog() == DialogResult.OK)
            {
                // if (settings.RLEcompressionCB.CheckState == CheckState.Checked) compression.RLECompress (bitmapFile.RawFormat;


                try
                {
                    stream = new StreamWriter(Sdlg.FileName);


                    stream.WriteLine("// Generated using GLCDToolskit by Yossi Shelly \u00A9Copyright");
                    stream.WriteLine("// The data is stream of pages of vertical bytes exactly as needed for GLCD screens");
                    stream.WriteLine("// Image: Monochrome 128x64 (128x8 pages) 8 pages = 64/8");
                    stream.WriteLine("// Data format: page 1: (vb1,vb2,vb3..... vb128) page 2: (vb1,vb2.... vb12).....page 8()");
                    stream.WriteLine();

                    String OnlyFileName = Sdlg.FileName.Substring (Sdlg.FileName.LastIndexOf("\\")+1);
                    OnlyFileName = OnlyFileName.Substring (0,OnlyFileName.IndexOf(".")).Replace(" ","_");

                    if (settings.UseFileNameAsArrayName)
                        stream.Write("const unsigned char " + OnlyFileName + "[] ");
                    else
                        stream.Write("const unsigned char " + settings.ArrayName + "[] ");


                    if (settings.PutDataInROM && settings.MicrocontrollerToUse == Settings.MicrocontrollerType.Atmel_AVR) stream.WriteLine("PROGMEM = {");
                    else stream.WriteLine("= {");

                    if (settings.RLECompress)
                        RLECompressAndCconvert(stream);
                    else
                        C_ConvertToFile(stream);


                    stream.WriteLine();
                    stream.Close();

                    success = true;
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("You are not allowed to access this file","Access deniged");
                    success = false;
                }
            }
            return success;
        }

        // this function generate binary file of the GLCD image data // raw formate
        public bool generateBinFile()
        {
            FileStream stream;
            SaveFileDialog Sdlg = new SaveFileDialog();


            Sdlg.Filter = "Bin files (*.bin) | *.bin";
            if (Sdlg.ShowDialog() == DialogResult.OK)
            {
                // if (settings.RLEcompressionCB.CheckState == CheckState.Checked) compression.RLECompress (bitmapFile.RawFormat;

                try
                {
                    stream = new FileStream(Sdlg.FileName, FileMode.Create, FileAccess.ReadWrite);

                    if (settings.RLECompress)
                        RLECompressAndCconvertToBin(stream);
                    else
                        Bin_ConvertToFile(stream);

                    stream.Close();

                }

                catch (System.IO.IOException)
                {
                    MessageBox.Show("File is accessed by another program");
                    return false;
                }
            }
            return true;
        }

        private bool generateAsmFile ()
        {
            StreamWriter stream;
            SaveFileDialog Sdlg = new SaveFileDialog();


            Sdlg.Filter = settings.AsmFileFilter;

            if (Sdlg.ShowDialog() == DialogResult.OK)
            {
                // if (settings.RLEcompressionCB.CheckState == CheckState.Checked) compression.RLECompress (bitmapFile.RawFormat;


                try
                {
                    stream = new StreamWriter(Sdlg.FileName);


                    stream.WriteLine("// Generated using GLCDToolskit by Yossi Shelly \u00A9Copyright");
                    stream.WriteLine("// The Image data is stream of pages of vertical bytes. each page is a line of width length");
                    stream.WriteLine("// Image: Monochrome 128x64 (128x8 pages) 8 pages = 64/8");
                    stream.WriteLine("// Data format: page 1: (vb1,vb2,vb3..... vb128) page 2: (vb1,vb2.... vb12).....page 8()");
                    stream.WriteLine();

                    String OnlyFileName = Sdlg.FileName.Substring(Sdlg.FileName.LastIndexOf("\\") + 1);
                    OnlyFileName = OnlyFileName.Substring(0, OnlyFileName.IndexOf(".")).Replace(" ", "_");

                    if (settings.RLECompress)
                        RLECompressAndCconvert(stream);
                    else
                        Asm_ConvertToFile(stream);


                    stream.WriteLine();
                    stream.Close();

                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("You are not allowed to access this file", "Access deniged");
                    return false;
                }

            }
            return true;
        }

        // refresh image when form activated
        private void Activated_GLCD(object sender, EventArgs e)
        {
#if SERIALKEY
            if (skgl.IsExpired && !RegistrationTimer.Enabled) {
                MessageBox.Show("The registeration has expired, please consider registeration to support me in future updates.","Registeration Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                RegistrationTimer.Enabled = true;
            }
#endif
            if (image.bitmap != null)
                if (settings.ImageGrixColors == Image.ImageDisplayEnum.Color)
                    image.DrawColoredPixeled(CreateGraphics(), this, (Width - (image.bitmap.Width * 5)) / 2, (Height - (image.bitmap.Height * 5)) / 2);
                else
                    image.DrawPixeled(CreateGraphics(),this, (Width - (image.bitmap.Width * 5)) / 2, (Height - (image.bitmap.Height * 5)) / 2);
      
        }

        private void LeaveForm(object sender, EventArgs e)
        {
            MessageBox.Show("test");    
        }

        private void GLCDFormClosed(object sender, FormClosedEventArgs e)
        {
            glcdkey.Close();          
        }

        private void charEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CharEditor charEditor = new CharEditor();
            charEditor.Show();
        }

        public String GetAsmLable
        {
            get
            {
                if (settings.UseFileNameAsLable)
                    return Filename_tb.Text.Substring(0, Filename_tb.Text.IndexOf("."));
                else
                    return settings.GetAsmLable;
            }
        }

        public static Color ImageBackgroundColor
        {
            get => BackgroundColor;

            set
            {
                BackgroundColor = value;
                
            }
           
        }

        private void SetStatusbarBpp ()
        {        
            bpp_s1.Text = "bpp: " + image.GetBPP();
        }

        

        private void saveImageAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Bitmap (*.bmp)|*.bmp|Portable Network Graphics (*.PNG)|*.PNG";

            if (image.bitmap != null)
            {

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImageFormat imageFormat = new ImageFormat(new Guid());
                    saveFileDialog.AddExtension = true;

                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            imageFormat = ImageFormat.Bmp;
                            break;

                        case 2:
                            imageFormat = ImageFormat.Png;
                            break;

                    }

                    ConvertToMonochrome();
                    Rectangle CopyRec = new Rectangle(0, 0, image.bitmap.Width, image.bitmap.Height);
                    Bitmap MonoChromeBitmap = image.bitmap.Clone(CopyRec, PixelFormat.Format1bppIndexed);
                    MonoChromeBitmap.Save(saveFileDialog.FileName, imageFormat);

                    MonoChromeBitmap.Dispose();
                }
            }
            else
                MessageBox.Show("There is no image to convert and save", "Save Error");
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registration register = new Registration();
            register.ShowDialog(this);
          
            if (register.DialogResult == DialogResult.Yes)
            {
                RegistrationTimer.Enabled = false;
                MessageBox.Show("You have successfully registered GLCDToolsKit. Thank you for purchasing my software and supporting my hard work.", "Registering successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
       

           
        }


        private void GLCDToolsKitForm_Validated(object sender, EventArgs e)
        {
  
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fonts fonts = new Fonts();
            fonts.ShowDialog(this);
        }
    }
}
