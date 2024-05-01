using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GLCDToolsKit
{
    public partial class Fonts : Form
    {
        List<string> fonts = new List<string>();
 
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
            LoadFont();
        }
        void LoadFont()
        {
            string fontName = fontListComboBox.SelectedItem.ToString();
            Font myFont = new Font(fontName, (int)fontSizeNumUpDown.Value);
            //fontDisp.SelectedFont = myFont;
            fontDisp.Font = myFont;
            fontDisp.DrawChar ('0');
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
        }

        private void fontSizeNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            LoadFont();
        }

        private void trimFontsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadSystemFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
        }

        private void imageGrid_Load(object sender, EventArgs e)
        {

        }

        private void imageGrid_Validated(object sender, EventArgs e)
        {

        }

        private void selectFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
        }
    }
}
