using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void imageGrid_Load(object sender, EventArgs e)
        {
       
        }

        private void imageGrid_Validated(object sender, EventArgs e)
        {
      
        }

        private void fontListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontName = fontListComboBox.SelectedItem.ToString();
            Font myFont = new Font(fontName, 8);
            Bitmap fontChar = new Bitmap(10, myFont.Height);
            Graphics bitGraph = Graphics.FromImage(fontChar);
            bitGraph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            bitGraph.DrawString("G", myFont, Brushes.Black, new PointF(0, 0));
            bitGraph.Dispose();
            CharPB.Image = fontChar;
            CharPB.ScaleImage();

            imageGrid.GridImage = fontChar;
        }
    }
}
