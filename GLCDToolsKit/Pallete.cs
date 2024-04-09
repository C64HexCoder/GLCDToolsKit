using System;
using System.Drawing;
using System.Windows.Forms;

namespace GLCDToolsKit
{
    public partial class Pallete : Form
    {
        Image image;
        public Color selectedColor;
        int NumColors;

        public Color backgroundColor = Color.White;

        public Pallete(Image img)
        {
            InitializeComponent();
            image = img;

            
        }


    

      
        private void SetBGButton_Click(object sender, EventArgs e)
        {   
            DialogResult = DialogResult.OK;
            this.Close();

        }

        private void button65_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


      
    }
}
