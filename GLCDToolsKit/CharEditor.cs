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
    public partial class CharEditor : Form
    {
        public CharEditor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CharEditor_Load(object sender, EventArgs e)
        {
            Button[,] buttonArray = new Button[8,8];

            for (int y=0; y<8; y++)
            {
                for (int x=0; x<8; x++)
                {
                    buttonArray[x, y] = new Button()
                    {
                        Location = new Point(13 + x * 33, 13 + y * 33),
                        BackColor = Color.LightSkyBlue,
                        Width = 32,
                        Height = 32
                    };

                    buttonArray[x, y].MouseUp += new MouseEventHandler(button_Click);
                   
                    Controls.Add(buttonArray[x, y]);
                   
                }
            } 
                   

        }

        private void button_Click(object sender, MouseEventArgs e)
        {
            //MouseEventArgs mouseEvent = (MouseEventArgs) e;
            Button button = (Button)sender;

            switch (e.Button)
            {
                case MouseButtons.Left:
                        button.BackColor = Color.Blue;
                     break;
                case MouseButtons.None:
                    break;
                case MouseButtons.Right:
                    button.BackColor = Color.LightSkyBlue;
                    break;
                case MouseButtons.Middle:
                    break;
                case MouseButtons.XButton1:
                    break;
                case MouseButtons.XButton2:
                    break;
            }
        }
}
}
