using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GfxLib;

namespace GLCDToolsKit
{
    public partial class Fonts : Form
    {
        List<string> fonts = new List<string>();
        List<FontDisp> fontsDisp = new List<FontDisp>();
        Font selectedFont = null;
        FontDisp selectedFontDisp = null;
        bool selected = false;
        public Fonts()
        {
            InitializeComponent();


            //imageGrid.SetPixel(0, 0,Color.Red);

            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                fonts.Add(font.Name);
                fontListComboBox.Items.Add(font.Name);
            }


        }

        private void CharPB_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


        }


        private void fontListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontName = ((ComboBox)sender).SelectedItem.ToString();
            selectedFont = new Font(fontName, (int)fontSizeNumUpDown.Value);
           
            LoadFont();
        }
        void LoadFont()
        {
            string fontName = fontListComboBox.SelectedItem.ToString();
            Font myFont = new Font(fontName, (int)fontSizeNumUpDown.Value);
            //fontDisp.SelectedFont = myFont;
            //Graphics fontSizeGfx = Graphics.FromImage(new Bitmap(1, 1));
            //fontSizeGfx.MeasureString()
            Bitmap fontChar = new Bitmap((int)fontSizeNumUpDown.Value, myFont.Height);
            Graphics bitGraph = Graphics.FromImage(fontChar);
            bitGraph.Clear(Color.Transparent);
            bitGraph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            bitGraph.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            bitGraph.DrawString("0", myFont, drawBrush, new PointF(0, 0));
            bitGraph.Dispose();
            CharPB.Image = fontChar;
            CharPB.ScaleImage();

            imageGrid.GridImage = fontChar;
            fontsDispPanel.Controls.Clear();
            LoadFontsInPanel(myFont, (char)fromNumUD.Value,(char)toNumUD.Value);
        }

        private void LoadFontsInPanel(Font font ,char startChar,char endChar)
        {
            if (fontsDispPanel.Controls.Count != 0)
                fontsDispPanel.Controls.Clear();

            int yPos = 0;
            FontDisp fontDisp;
            for (char i = (char)fromNumUD.Value; i <= toNumUD.Value; i++)
            {
               
                fontDisp = new FontDisp(font, i,fontsDispPanel.Width - 20);
                fontDisp.AutoSize = false;
                fontDisp.SelectedColor = Color.AliceBlue;
                fontDisp.Top = yPos;
                fontDisp.CellsWidthHeight = 6;
                fontDisp.DrawChar(i,fontsDispPanel.Width -20);
                fontDisp.Click += fontClicked;
                yPos += fontDisp.Height + 5;
                fontsDispPanel.Controls.Add(fontDisp);
            }
        }

        private void LoadFontsInPanel(char startChar, char endChar)
        {
            if (fontsDispPanel.Controls.Count != 0)
                fontsDispPanel.Controls.Clear();

            int yPos = 0;
            FontDisp fontDisp;
            for (char i = (char)fromNumUD.Value; i <= toNumUD.Value; i++)
            {             
                fontDisp = new FontDisp(i);
                fontDisp.Top = yPos;
                fontDisp.SelectedColor = Color.AliceBlue;
                yPos += fontDisp.Height + 5;
                fontDisp.Click += fontClicked;

                fontsDispPanel.Controls.Add(fontDisp);
            }
        }

        void fontClicked (object sender, EventArgs e)
        {
            FontDisp fontDisp = (FontDisp)sender;
            fontDisp.Selected = true;

            if (selectedFontDisp != null)
                selectedFontDisp.Selected = false;

            selectedFontDisp = fontDisp;
        }
        private void loadSystemFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
        }

        private void Fonts_Load(object sender, EventArgs e)
        {
            fontListComboBox.SelectedIndex = 0;
   
        }

        private void toFromNumUD_ValueChanged(object sender, EventArgs e)
        {
            LoadFontsInPanel(selectedFont,(char)fromNumUD.Value,(char)toNumUD.Value);
        }

        private void saveSourceAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 1: for (int x=0; x< selectedFontDisp.GridWidth; x++)
                                for (int y=0; y<selectedFontDisp.GridHeight; y++)
                            {

                            }
                            
                        break;
                    case 2:
                        byte temp = selectedFontDisp.GetVerticalByte(2, 0);
                        break;
                }
            }
        }

        private void fontSizeNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            string fontName = fontListComboBox.SelectedItem.ToString();
            selectedFont = new Font(fontName, (int)fontSizeNumUpDown.Value);

            LoadFont();
        }
    }
}
