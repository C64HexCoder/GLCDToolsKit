using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace GLCDToolsKit
{
    public class Image
    {
        private ImgInfo imginfo;
        private Pallete Pallete;
        public BitmapData BitmapData;
        public byte[] ImageData;
        //private byte[] ImageMonoData;
        //private bool Indexed;
        //private byte BitsPerPixel;
        public enum ImageDisplayEnum
        {
            Color,
            Mono
        };

        private ImageDisplayEnum ImageDisplay;

        private int NumOfColors = 0;
        public Color BackgroundColor = Color.FromArgb (255,255,255); 

        private struct RGB {
            public byte Blue;
            public byte Green;
            public byte Red;
        };


        private List<Color> ImageColors = new List<Color>();
        
        public Image(ImgInfo imgI,Pallete pallete)
        {
            imginfo = imgI;
            Pallete = pallete;
        }

   
        enum MonoColor{
            Black,
            White
        };

         
        private Bitmap _bitmap;
        
        public Bitmap bitmap
        {
            get {
                return _bitmap;
            }

            set
            {
                _bitmap = value;

                if (ImageColors.Count != 0)
                    ImageColors.Clear();
      
                if (_bitmap != null)
                {
                    Rectangle bitmapRec = new Rectangle(0, 0, _bitmap.Width, _bitmap.Height);
                    BitmapData = _bitmap.LockBits(bitmapRec, ImageLockMode.ReadWrite, _bitmap.PixelFormat);

                    // Get the address of the first line.
                    IntPtr ptr = BitmapData.Scan0;

                    // Declare an array to hold the bytes of the bitmap.
                    int bytes = Math.Abs(BitmapData.Stride) * BitmapData.Height;
                    ImageData = new byte[bytes];

                    // Copy the RGB values into the array.
                    Marshal.Copy(ptr, ImageData, 0, bytes);

                    _bitmap.UnlockBits(BitmapData);

                    

                    if (IsIndexed())
                    {
                        Pallete.updatePallete(_bitmap);

                    }
                    else
                        GetColorsFromImage();

                }
           }
        }


        public void ConvertToMono()
        {
            if (IsIndexed())
                ConvertIndexedToMono();
            else
                ConvertNonIndexedToMono();
        }

        private void ConvertNonIndexedToMono()
        {
            int bytes = Math.Abs(BitmapData.Stride) * BitmapData.Height;
            Color color;

            int i = 0;
            while (i < (BitmapData.Stride * BitmapData.Height))
            {
                // The colors in the ImageData (from the file) are BGR(A) format
                color = GetPixel(i);


                if (color != BackgroundColor)
                {
                    SetPixel(i, Color.Green);
                }


                if (bitmap.PixelFormat == PixelFormat.Format24bppRgb)
                    i += 3;
                else
                    i += 4;

            }

            Marshal.Copy(ImageData, 0, BitmapData.Scan0, bytes);

        }

        private void ConvertIndexedToMono ()
        {
            byte BColorIdx = ScanPalleteForBackgroundColor();
            int bytes = Math.Abs(BitmapData.Stride) * BitmapData.Height;

            ColorPalette NewPallete = bitmap.Palette;

            NewPallete.Entries[0] = Color.White;
            NewPallete.Entries[1] = Color.Red;

     
            bitmap.Palette = NewPallete;

            for (int x=0; x< bitmap.Width*bitmap.Height;x++)
            {
                if (ImageData[x] == BColorIdx)
                    ImageData[x] = 0;
                else
                    ImageData[x] = 1;
            }

            Marshal.Copy(ImageData, 0, BitmapData.Scan0, bytes);
            Pallete.updatePallete(bitmap);

        }


        private byte ScanPalleteForBackgroundColor ()
        {
            int NumOfColors = Convert.ToInt32 (Math.Pow(2, Convert.ToInt32(GetBPP())));

            byte i = 0;
            while (BackgroundColor != bitmap.Palette.Entries[i])
            {
                i++;
            }

            return i;
        }

        // return a pixel color from 24bpp and 32bpp image.
        private Color GetPixel (int x, int y)
        {
            RGB Pixel;
            int ByteOffset = (y * bitmap.Width + x);

            if (bitmap.PixelFormat == PixelFormat.Format24bppRgb)
                ByteOffset *= 3;
            else if (bitmap.PixelFormat == PixelFormat.Format32bppArgb)
                ByteOffset *= 4;

            Pixel.Blue = ImageData[ByteOffset];
            Pixel.Green = ImageData[ByteOffset+1];
            Pixel.Red = ImageData[ByteOffset+2];

            return Color.FromArgb(Pixel.Red, Pixel.Green, Pixel.Blue);

        }

        private Color GetPixel (int index)
        {
            RGB Pixel;

            Pixel.Blue = ImageData[index];
            Pixel.Green = ImageData[index + 1];
            Pixel.Red = ImageData[index + 2];

            return Color.FromArgb(Pixel.Red, Pixel.Green, Pixel.Blue);
        }


        // SetPixel in 24bpp and 32bpp image
        private void SetPixel (int x, int y, Color color)
        {
            int ByteOffset = (y * bitmap.Width + x);

            if (bitmap.PixelFormat == PixelFormat.Format24bppRgb)
                ByteOffset *= 3;
            else if (bitmap.PixelFormat == PixelFormat.Format32bppArgb)
                ByteOffset *= 4;

            ImageData[ByteOffset] = color.B;
            ImageData[ByteOffset + 1] = color.G;
            ImageData[ByteOffset + 2] = color.R;

        }

        private void SetPixel (int index, Color color)
        {
            ImageData[index] = color.B;
            ImageData[index + 1] = color.G;
            ImageData[index + 2] = color.R;
        }


        // Collect all the Colors in the image and put it in a List<Colors> called ImageColors
        public void GetColorsFromImage ()
        {
            RGB Pixel;
            Color color;
            NumOfColors = 0;
            

            if (!IsIndexed())
            {
                if (bitmap.PixelFormat == PixelFormat.Format24bppRgb)
                {

                    int i = 0;
                    while (i < (BitmapData.Stride * BitmapData.Height))
                    {
                        // The colors in the ImageData (from the file) are BGR(A) format
                        Pixel.Blue = ImageData[i++];
                        Pixel.Green = ImageData[i++];
                        Pixel.Red = ImageData[i++];

                        color = Color.FromArgb(Pixel.Red, Pixel.Green, Pixel.Blue);

                        if (!ImageColors.Contains(color))
                        {
                            ImageColors.Add(color);
                            NumOfColors++;
                        }

                    }
                }
                else if (bitmap.PixelFormat == PixelFormat.Format32bppArgb)
                {
                    int i = 0;
                    while (i < (BitmapData.Stride * BitmapData.Height))
                    {
                       
                        Pixel.Blue = ImageData[i++];
                        Pixel.Green = ImageData[i++];
                        Pixel.Red = ImageData[i++];
                        i++; // Skip Alpha byte

                        color = Color.FromArgb(Pixel.Red, Pixel.Green, Pixel.Blue);

                        if (!ImageColors.Contains(color))
                        {
                            ImageColors.Add(color);
                            NumOfColors++;
                        }

                    }
                }

            }
        }

        // return True if image in Indexed
        public bool IsIndexed()
        {
            if (_bitmap.PixelFormat == PixelFormat.Format1bppIndexed || _bitmap.PixelFormat == PixelFormat.Format4bppIndexed || _bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                return true;
              else
                return false;
  
        }

        private MonoColor WhiteBlackEstimation(int X, int Y)
        {
     
            //if (bitmap.GetPixel(X,Y).R >= 128 && 
            return MonoColor.Black;
        }


        // draw pixelized image only suitable for 24bpp.
        // i've programmed it to replace DrawPixeld to make it faster, but the are 
        // merly at the same speed.

        // draw the image using squeres to make it look as on an monochrome lcd
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gfx"></param>
        /// <param name="PosX"></param>
        /// <param name="PosY"></param>
        //public void DrawPixeld(Graphics gfx, int PosX, int PosY)
        //{
        //    RGB Pixel;
        //   Color color;

        //    SolidBrush PixelOn = new SolidBrush(Color.Green), PixelOff = new SolidBrush(Color.White);


        //    for  (int y =0; y < BitmapData.Height; y++)
        //    {
        //        int x = 0,pixelX = 0;
        //        while (x < BitmapData.Stride)
        //        {
        //            Pixel.Blue = ImageData[y * BitmapData.Stride + x++];
        //           Pixel.Green = ImageData[y * BitmapData.Stride + x++];
        //            Pixel.Red = ImageData[y * BitmapData.Stride + x++];



        //            color = Color.FromArgb(Pixel.Red, Pixel.Green, Pixel.Blue);

        //            if (color.ToArgb() != BackgroundColor.ToArgb())
        //                gfx.FillRectangle(PixelOn, new Rectangle(PosX + pixelX * 5, PosY + y * 5, 4, 4));
        //            else
        //                gfx.FillRectangle(PixelOff, new Rectangle(PosX + pixelX * 5, PosY + y * 5, 4, 4));

        //            pixelX++;
        //        }
        //    }
        //}



        public void DrawPixeled (Graphics gfx, Form parent,int PosX, int PosY)
        {
            //Pen pen = new Pen(Color.Green, 1);
            //Rectangle rectangle = new Rectangle();
            gfx.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
            gfx.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.None;
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

            BufferedGraphicsContext myBufferedGfxContext = BufferedGraphicsManager.Current;
            BufferedGraphics buffer;

            buffer = myBufferedGfxContext.Allocate(gfx, parent.DisplayRectangle);
            buffer.Graphics.Clear(Control.DefaultBackColor);


            try
            {
                SolidBrush PixelOn = new SolidBrush(Color.Green), PixelOff = new SolidBrush(Color.White);
                
                for (byte x = 0; x < bitmap.Width; x++)
                    for (byte y = 0; y < bitmap.Height; y++)
                        if (bitmap.GetPixel(x, y).ToArgb() != BackgroundColor.ToArgb())
                            buffer.Graphics.FillRectangle(PixelOn, new Rectangle(PosX + x * 5, PosY + y * 5, 4, 4));
                    else
                        buffer.Graphics.FillRectangle(PixelOff, new Rectangle(PosX + x * 5, PosY + y * 5, 4, 4));

            }
            catch (NullReferenceException e)
            {
                MessageBox.Show(e.Message);   
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show(e.Message, "Error");
            }
            buffer.Render(gfx);
            buffer.Dispose();
        }

        public void DrawColoredPixeled(Graphics gfx, Form parent ,int PosX, int PosY)
        {
            //Pen pen = new Pen(Color.Green, 1);
            //Rectangle rectangle = new Rectangle();
            gfx.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
            gfx.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.None;
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

            BufferedGraphicsContext myBufferedGfxContext = BufferedGraphicsManager.Current;
            BufferedGraphics buffer;

            buffer = myBufferedGfxContext.Allocate(gfx, parent.DisplayRectangle);
            buffer.Graphics.Clear(Control.DefaultBackColor);

            try
            {
                SolidBrush PixelOn = new SolidBrush(Color.Green), PixelOff = new SolidBrush(Color.White);

                for (byte x = 0; x < bitmap.Width; x++)
                    for (byte y = 0; y < bitmap.Height; y++)
                            buffer.Graphics.FillRectangle(new SolidBrush (bitmap.GetPixel(x,y)), new Rectangle(PosX + x * 5, PosY + y * 5, 4, 4));

            }
            catch (NullReferenceException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show(e.Message, "Error");
            }

            buffer.Render(gfx);
            buffer.Dispose();
        }

        // the image is build from memory orgenized byte after byte, arranged horizontally in memory.
        // this function reads byte Vertical byte from memory in location x,page;
        public byte VerticalByte(byte X, byte page)
        {
            Color TmpColor;
            byte pixel = 0;

            for (byte y = 0; y < 8; y++)
            {
                TmpColor = bitmap.GetPixel(X, (page * 8) + y);
                if (TmpColor.ToArgb() != BackgroundColor.ToArgb())
                    pixel |= (byte)(1 << y);
            }

            return pixel;
        }

        public byte HorizontalByte(byte Xpos, byte Ypos)
        {

            byte OutByte = 0;
            int BytePos = Xpos * 8; 

            for (int i=0; i<8; i++)
            {
                if (bitmap.GetPixel (BytePos+i,Ypos).ToArgb() != BackgroundColor.ToArgb())
                {
                    OutByte |= 0x01;
                }
                OutByte <<= 1;
            }
            //image.bitmap.LockBits
            return OutByte;
        }

        public List<Color> GetImageColors => ImageColors;

        public int GetNumOfColors
        {
            get => NumOfColors;

        }

        public ImageDisplayEnum ImageGridColors
        {
            get
            {
                return ImageDisplay;
            }

            set
            {
                ImageDisplay = value;
            }
        }

        public string GetBPP()
        {
            string bpp = bitmap.PixelFormat.ToString().Substring(6);
            return bpp.Remove(bpp.IndexOf("b"));
        }

    }
}
