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


        public void updatePallete (Bitmap bitmap)
        {
            SuspendLayout ();
            try
            {
                
     /*           switch (bitmap.PixelFormat)
                {

                    case System.Drawing.Imaging.PixelFormat.Format1bppIndexed:
                        NumColors = 2;
                        break;

                    case System.Drawing.Imaging.PixelFormat.Format4bppIndexed:
                        NumColors = Convert.ToInt32 (Math.Pow (2,4));
                        break;

                    default:
                    case System.Drawing.Imaging.PixelFormat.Format8bppIndexed:
                        NumColors = Convert.ToInt32(Math.Pow(2,8));
                        
                        break;
 
                } */

                PlaceControls(bitmap.Palette.Entries.Length);

                int i = 0;
                foreach (Color color in bitmap.Palette.Entries)
                {
                    Colors.Controls[i].BackColor = color;
                    Colors.Controls[i].Click += ColorClick;
                    i++;
                }

          /*      for (int i = 0; i < NumColors; i++)
                {
                    Colors.Controls[i].BackColor = bitmap.Palette.Entries[i];                                   // copy the pallete colors to each of teh Pallete "Color" buttons.
                    Colors.Controls[i].Click += ColorClick;                                                     // set a ColorClick event for each of the Pallete "Color" buttons.

                }*/

                backgroundColor = bitmap.Palette.Entries[0];
                ColorClick(Colors.Controls[0], EventArgs.Empty);         // call the ColorClick event
            }
            catch (NullReferenceException)
            {

            }

            ResumeLayout ();
        }

        private void ColorClick(object sender, EventArgs e)
        {
            selectedColor = ((Button)sender).BackColor;

            RedTB.Text = ((Button)sender).BackColor.R.ToString();
            GreenTB.Text = ((Button)sender).BackColor.G.ToString();
            BlueTB.Text = ((Button)sender).BackColor.B.ToString();
            AlphaTB.Text = ((Button)sender).BackColor.A.ToString();

            SelectedColorBT.BackColor = selectedColor;
            ColorIdx.Text = ((Button)sender).TabIndex.ToString();
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


        private void PlaceControls(int NumOfColors)
        {
            int InARow, Rows;
            int ButtonWidth;

            int SpaceFromForm ,CellSpacing;

            switch (NumOfColors)
            {
                case 2:
                    InARow = 2;
                    Rows = 1;
                    ButtonWidth = 256 / 2;
                    SpaceFromForm = 7;
                    CellSpacing = 10;
                    break;

                case 16:
                    
                    ButtonWidth = 64;
                    //Rows = InARow = Convert.ToInt32(Math.Sqrt(NumOfColors));
            
                    Rows = InARow = 4;
                    SpaceFromForm = 8;
                    CellSpacing = 2;
                    break;

                default:
                case 256:
                    ButtonWidth = 16;
                    //Rows = InARow = Convert.ToInt32(Math.Sqrt(NumOfColors)); 
                    SpaceFromForm = 4;
                    CellSpacing =
                    Rows = InARow = 16;
                    break;
            }

            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < InARow; x++)
                {
                    Button btn = new Button();
                    btn.Width = ButtonWidth;
                    btn.Height = ButtonWidth;
                    btn.FlatStyle = FlatStyle.Popup;
                    btn.Location = new Point (x * (ButtonWidth+CellSpacing)+SpaceFromForm, y * (ButtonWidth+CellSpacing)+SpaceFromForm);
                    Colors.Controls.Add(btn);
                }
            }

            //Width = (ButtonWidth+CellSpacing)*InARow + 50;
            //Height = (ButtonWidth+CellSpacing) * InARow + 100;
        }

        public void DisposeButtons ()
        {
            Colors.Controls.Clear();
        }
    }
}
