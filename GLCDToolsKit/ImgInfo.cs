using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GLCDToolsKit
{
    public partial class ImgInfo : Form
    {
        private Image image;
        public ImgInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }


        public void SetImage (Image image)
        {
            this.image = image;
            Width_tb.Text = image.bitmap.Width.ToString();
            Height_tb.Text = image.bitmap.Height.ToString();
            pictureBox.Image = image.bitmap;
            pictureBox.Width = image.bitmap.Width;
            pictureBox.Height = image.bitmap.Height;
            ColorsLbl.Text = image.GetNumOfColors.ToString();
            BppLbl.Text = image.GetBPP();
            IndexedCb.Checked = image.IsIndexed();
        }
    }
}
