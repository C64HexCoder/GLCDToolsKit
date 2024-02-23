using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.Permissions;
namespace GLCDToolsKit
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;

            RegistryKey glcdkey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\GLCD Tollskit");

            glcdkey.SetValue("RLE Compression", RLECompress);
            glcdkey.SetValue("Microcontroller", MicrocontrollerToUse, RegistryValueKind.DWord);
            glcdkey.SetValue("Data Structure Format", DataStructureFormat, RegistryValueKind.DWord);
            glcdkey.SetValue("Put data in ROM", PutDataInROM);
            glcdkey.SetValue("C File Extention", CFileExtention, RegistryValueKind.DWord);
            glcdkey.SetValue("Use filename As Array name", UseFileNameAsArrayName);
            glcdkey.SetValue("Use File Name As Lable", UseFileNameAsLable);
            glcdkey.SetValue("Array Name", ArrayName, RegistryValueKind.String);
            glcdkey.SetValue("Header", AddHeader);
            glcdkey.SetValue("LCD Type", LcdComBox.SelectedIndex, RegistryValueKind.DWord);
            glcdkey.SetValue("Width Resolution", WidthTB.Text);
            glcdkey.SetValue("Hight Resolution", hightTB.Text);
            glcdkey.SetValue("ASM File Extention", AsmFileExtention, RegistryValueKind.DWord);
            glcdkey.SetValue("Number Base To Use", NumBaseToUse, RegistryValueKind.DWord);
            glcdkey.SetValue("Rom Address", ROMAddress);
            glcdkey.SetValue("Byte Orientation", ByteOrientation, RegistryValueKind.DWord);
            glcdkey.SetValue("Bytes Per Raw", BytesPerLineCB.SelectedIndex, RegistryValueKind.DWord);
            glcdkey.SetValue("Image Grid Colors", ImageGrixColors, RegistryValueKind.DWord);
            glcdkey.Close();

            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void ArrayNameCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ArrayNameCB.Checked)
                ArrayNameTB.Enabled = false;
            else
                ArrayNameTB.Enabled = true;

        }

        private new void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == 0x08 || e.KeyChar == 127))
                e.KeyChar = '\0';
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LcdComBox.SelectedIndex;

            switch (index)
            {
                case 0:
                    WidthTB.Text = "128";
                    hightTB.Text = "64";
                    break;
                case 1:
                    WidthTB.Text = "128";
                    hightTB.Text = "32";
                    break;
                case 2:
                    WidthTB.Text = "192";
                    hightTB.Text = "64";
                    break;
                case 3:
                    WidthTB.Text = "84";
                    hightTB.Text = "48";
                    break;
                default:
                    break;

            }
        }

        public enum LanguageFormat { C, Asm, Bin };

        public LanguageFormat DataStructureFormat
        {
            get
            {
                if (C_rb.Checked)
                    return LanguageFormat.C;
                else if (ASM_rb.Checked)
                    return LanguageFormat.Asm;
                else
                    return LanguageFormat.Bin;

            }

            set
            {
                switch (value)
                {
                    case LanguageFormat.C:
                        C_rb.Checked = true;
                        break;
                    case LanguageFormat.Asm:
                        ASM_rb.Checked = true;
                        break;
                    case LanguageFormat.Bin:
                        Binary_rb.Checked = true;
                        break;
                }
            }
        }

        public enum MicrocontrollerType { Atmel_AVR, Microchip_PIC };

        public MicrocontrollerType MicrocontrollerToUse
        {
            get
            {
                if (AVR_rb.Checked)
                    return MicrocontrollerType.Atmel_AVR;
                else
                    return MicrocontrollerType.Microchip_PIC;
            }

            set
            {
                if (value == MicrocontrollerType.Atmel_AVR)
                    AVR_rb.Checked = true;
                else
                    PIC_rb.Checked = true;
            }
        }

        public enum CFileExtentionType { C_File, C_Header, CPP_File };

        public CFileExtentionType CFileExtention
        {
            get
            {
                if (c_header.Checked)
                {
                    return CFileExtentionType.C_Header;
                }
                else if (c_file.Checked)
                {
                    return CFileExtentionType.C_File;
                }
                else
                    return CFileExtentionType.CPP_File;
            }

            set
            {
                switch (value)
                {
                    case CFileExtentionType.C_File:
                        c_file.Checked = true;
                        break;
                    case CFileExtentionType.C_Header:
                        c_header.Checked = true;
                        break;
                    case CFileExtentionType.CPP_File:
                        cpp_file.Checked = true;
                        break;
                }
            }
        }

        public enum AsmFileExtentionType { inc_File, asm_File, a_File };

        public AsmFileExtentionType AsmFileExtention
        {
            get
            {
                if (inc_File.Checked)
                    return AsmFileExtentionType.inc_File;
                else if (asm_File.Checked)
                    return AsmFileExtentionType.asm_File;
                else
                    return AsmFileExtentionType.a_File;
            }

            set
            {
                switch (value)
                {
                    case AsmFileExtentionType.inc_File:
                        inc_File.Checked = true;
                        break;
                    case AsmFileExtentionType.asm_File:
                        asm_File.Checked = true;
                        break;
                    case AsmFileExtentionType.a_File:
                        a_File.Checked = true;
                        break;
                }
            }
        }

        public enum NumberBase { Hex, Dec };

        public NumberBase NumBaseToUse
        {
            get
            {
                if (Hex_rb.Checked)
                    return NumberBase.Hex;
                else
                    return NumberBase.Dec;
            }

            set
            {
                switch (value)
                {
                    case NumberBase.Hex:
                        Hex_rb.Checked = true;
                        break;
                    case NumberBase.Dec:
                        Dec_rb.Checked = true;
                        break;
                }
            }
        }

        public Boolean PutDataInROM
        {
            get => ProgramMemCk.Checked ? true : false;
            set => ProgramMemCk.Checked = value;
        }

        public Boolean RLECompress
        {
            get => RLEcompressionCB.Checked ? true : false;
            set => RLEcompressionCB.Checked = value;
        }

        public Boolean AddHeader
        {
            get => HeaderCB.Checked ? true : false;
            set => HeaderCB.Checked = value;
        }

        public Boolean UseFileNameAsArrayName
        {
            get => ArrayNameCB.Checked ? true : false;
            set => ArrayNameCB.Checked = value;

        }

        public String ArrayName
        {
            get => ArrayNameTB.Text;
            set => ArrayNameTB.Text = value;
        }

        public Boolean UseFileNameAsLable
        {
            get => UseFileNameAsLable_cb.Checked ? true : false;
            set => UseFileNameAsLable_cb.Checked = value;
        }

        private void UseFileNameAsLable_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).CheckState == CheckState.Unchecked)
                LableName_tb.Enabled = true;
            else
                LableName_tb.Enabled = false;
        }

        private void C_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (C_rb.Checked)
                HeaderCB.Enabled = true;
            else
                HeaderCB.Enabled = false;
        }

        public String AssemblerDirective
        {
            get
            {
                if (MicrocontrollerToUse == MicrocontrollerType.Atmel_AVR)
                    return ".DB ";
                else if (PutDataInROM)
                    return "DE ";
                else
                    return "DT ";
            }
        }

        public String CFileFilter
        {
            get
            {
                switch (CFileExtention)
                {
                    case CFileExtentionType.C_File:
                        return "C files (*.c) | *.c";
                    case CFileExtentionType.C_Header:
                        return "C Header (*.h) | *.h";
                    case CFileExtentionType.CPP_File:
                        return "Cpp Files (*.cpp) | *.cpp";
                    default:
                        return "C files (*.c) | *.c";
                }
            }
        }

        public String AsmFileFilter
        {
            get
            {
                switch (AsmFileExtention)
                {
                    case AsmFileExtentionType.asm_File:
                        return "ASM files (*.asm) | *.asm";
                    case AsmFileExtentionType.a_File:
                        return "ASM files (*.a) | *.a";
                    case AsmFileExtentionType.inc_File:
                        return "ASM include file (*.inc) | *.inc";
                    default:
                        return "ASM files (*.asm) | *.asm";

                }
            }
        }

        public String GetFileExtentionString
        {
            get
            {
                if (DataStructureFormat == LanguageFormat.C)
                {
                    switch (CFileExtention)
                    {
                        case CFileExtentionType.CPP_File:
                            return ".cpp";
                        case CFileExtentionType.C_File:
                            return ".c";
                        case CFileExtentionType.C_Header:
                            return ".h";
                    }
                }
                else if (DataStructureFormat == LanguageFormat.Asm)
                {
                    switch (AsmFileExtention)
                    {
                        case AsmFileExtentionType.asm_File:
                            return ".asm";
                        case AsmFileExtentionType.a_File:
                            return ".a";
                        case AsmFileExtentionType.inc_File:
                            return ".inc";
                    }
                }
                else
                    return ".bin";

                return "";
            }
        }

        public String ROMAddress
        {
            get => ROM_Addr_tb.Text;
            set => ROM_Addr_tb.Text = value;
        }

        public enum Orientation { Vertical, Horizontal };

        public Orientation ByteOrientation
        {
            get
            {
                if (verticalRB.Checked)
                    return Orientation.Vertical;
                else
                    return Orientation.Horizontal;
            }

            set
            {
                if (value == Orientation.Vertical)
                    verticalRB.Checked = true;
                else
                    horizontalRB.Checked = true;
            }
        }

        private void ProgramMemCk_CheckedChanged(object sender, EventArgs e)
        {
            if (PutDataInROM && MicrocontrollerToUse == MicrocontrollerType.Microchip_PIC)
                ROM_Addr_tb.Enabled = true;
            else
                ROM_Addr_tb.Enabled = false;
        }

        private void PIC_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (PutDataInROM)
                ROM_Addr_tb.Enabled = true;
            else
                ROM_Addr_tb.Enabled = false;
        }

        public String GetAsmLable => LableName_tb.Text;


        public int BytesPerRaw
        {
            get
            {
                int index = BytesPerLineCB.SelectedIndex;

                switch (index)
                {
                    default:
                    case 0:
                        return 8;
                    case 1:
                        return 16;
                    case 2:
                        return 32;
                    case 3:
                        return 64;
                }
            }

            set
            {
                BytesPerLineCB.SelectedIndex = value;
            }
        }

        private void Binary_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (DataStructureFormat == LanguageFormat.Bin)
            {
                BytesPerLineCB.Enabled = false;
            }
            else
                BytesPerLineCB.Enabled = true;

        }

        private void RLEcompressionCB_CheckedChanged(object sender, EventArgs e)
        {
            if (RLECompress)
                HeaderCB.Enabled = true;
            else
                HeaderCB.Enabled = false;
        }

        private void AVR_rb_CheckedChanged(object sender, EventArgs e)
        {
            ROM_Addr_tb.Enabled = false;
        }

        public Image.ImageDisplayEnum ImageGrixColors
        {
            get
            {
                if (ColorRb.Checked == true)
                {
                    return Image.ImageDisplayEnum.Color;
                }
                else
                    return Image.ImageDisplayEnum.Mono;

            }

            set
            {
                if (value == Image.ImageDisplayEnum.Color)
                    ColorRb.Checked = true;
                else
                    MonoRb.Checked = true;
            }
        }
    }
}
