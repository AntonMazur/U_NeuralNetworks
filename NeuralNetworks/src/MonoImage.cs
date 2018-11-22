using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworks.src
{
    class MonoImage
    {
        private Size orig;
        private Size comp;
        private Size scaleCoef;
        private bool[,] imageArr;
        private bool[,] compImage;

        public MonoImage(bool[,] image)
        {
            this.orig = new Size(image.GetLength(0), image.GetLength(1));
            this.imageArr = image;
        }

        public MonoImage(Image image) : this(toMonoArr(image)) {}

        public MonoImage(Image image, int width, int height) : this(image)
        {
            this.comp = new Size(width, height);
            this.compImage = compress(this.imageArr, width, height);
            this.scaleCoef = new Size(orig.Width / comp.Width, orig.Height / comp.Height);
        }

        public int width()
        {
            return imageArr.GetLength(0);
        }

        public int height()
        {
            return imageArr.GetLength(1);
        }

        public bool getVal(int row, int column)
        {
            return imageArr[row, column];
        }

        public bool[,] getCompressedImageArr()
        {
            return compImage;
        }

        public Image getCompressedImage()
        {
            var res = new Bitmap(orig.Width, orig.Height);
            var resArray = new byte[orig.Height * orig.Width];
            for (int i = 0; i < comp.Height; i++)
            {
                for (int j = 0; j < comp.Width; j++)
                {
                    var isBlack = compImage[i, j];
                    var startH = i * scaleCoef.Height;
                    for (int k = startH; k < (orig.Height < startH + 2 * scaleCoef.Height ? orig.Height : startH + scaleCoef.Height); k++)
                    {
                        var startW = j * scaleCoef.Width;
                        for (int l = startW; l < (orig.Width < startW + 2 * scaleCoef.Width ? orig.Width : startW + scaleCoef.Width) ; l++)
                        {
                            resArray[k * orig.Width + l] = (byte) (isBlack ? 0 : 255);
                        }
                    }
                }
            }

            var bmpdata = res.LockBits(new Rectangle(0, 0, res.Width, res.Height), ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
            int numbytes = bmpdata.Stride * res.Height;            
            IntPtr ptr = bmpdata.Scan0;
            Marshal.Copy(resArray, 0, ptr, numbytes);
            res.UnlockBits(bmpdata);

            return res;
        }

        private static bool[,] compress(bool[,] image, int targetWidth, int targetHeight)
        {
            var width = image.GetLength(1);
            var height = image.GetLength(0);

            var compressPoligonSize = new Size(width / targetWidth, height / targetHeight);

            var compressedImage = new bool[targetHeight, targetWidth];

            var row = 0;
            var col = 0;

            for (int i = 0; i < (row == targetHeight ? 0 : height); i += compressPoligonSize.Height)
            {
                for (int j = 0; j < (col == targetWidth ? 0 : width) ; j += compressPoligonSize.Width)
                {
                    var endHeight = Math.Min(i + compressPoligonSize.Height, height - 1);
                    var endWidth = Math.Min(j + compressPoligonSize.Width, width - 1);
                    compressedImage[row, col++] = getDominatePoligonVal(image, j, i, endWidth, endHeight);
                }
                col = 0;
                row++;
            }

            return compressedImage;
        }

        private static bool getDominatePoligonVal(bool[,] arr, int startX, int startY, int endX, int endY)
        {
            var valCounter = 0;

            for (int i = startY; i < endY; i++)
            {
                for (int j = startX; j < endX; j++)
                {
                    valCounter += arr[i, j] ? 1 : -1;
                }
            }

            return valCounter >= 0 ? true : false;
        }

        private static bool[,] toMonoArr(Image image)
        {
            var inBitmap = new Bitmap(image);
            var imageBytes = bitmapToByteArray(inBitmap);
            var stride = imageBytes.Length / (image.Width * image.Height);
            var monoImageArr = new bool[image.Height, image.Width];

            for (int i = 0; i < image.Height; i++)
            {
                var startRowIndex = i * image.Width;
                for (int j = 0; j < image.Width; j++)
                {
                    monoImageArr[i, j] = imageBytes[startRowIndex + j] != 0 ? true : false;
                }
            }

            return monoImageArr;
        }

        public static byte[] bitmapToByteArray(Bitmap bitmap)
        {

            BitmapData bmpdata = null;

            try
            {
                bmpdata = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
                int numbytes = bmpdata.Stride * bitmap.Height;
                byte[] bytedata = new byte[numbytes];
                IntPtr ptr = bmpdata.Scan0;

                Marshal.Copy(ptr, bytedata, 0, numbytes);

                return bytedata;
            }
            finally
            {
                if (bmpdata != null)
                    bitmap.UnlockBits(bmpdata);
            }

        }
    }
}
