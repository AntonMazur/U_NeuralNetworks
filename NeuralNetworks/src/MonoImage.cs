using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworks.src
{
    class MonoImage
    {
        private bool[,] image;

        public MonoImage(bool[,] image)
        {
            this.image = image;
        }

        public MonoImage(Image image)
        {
            this.image = toMonoArr(image);
        }

        public MonoImage(Image image, int width, int height) 
        {
            this.image = toMonoArr(image);
        }

        public int width()
        {
            return image.GetLength(0);
        }

        public int height()
        {
            return image.GetLength(1);
        }

        public bool getVal(int row, int column)
        {
            return image[row, column];
        }

        private static bool[,] compress(bool[,] image, int targetWidth, int targetHeight)
        {
            var width = image.GetLength(1);
            var height = image.GetLength(0);

            var compressPoligonSize = new Size(image.GetLength(1) / width, image.GetLength(0) / height);

            var compressedImage = new bool[targetHeight, targetWidth];

            var row = 0;
            var col = 0;

            for (int i = 0; i < height; i+=compressPoligonSize.Height)
            {
                for (int j = 0; j < width; j += compressPoligonSize.Width)
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
            
            var imageBytes = imageToBytes(image);
            var stride = imageBytes.Length / (image.Width * image.Height);
            var monoImageArr = new bool[image.Height, image.Width];

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    var coloration = 0;

                    for (int k = 0; k < stride; k++)
                    {
                        coloration += imageBytes[(i + 1) * j + k];
                    }

                    monoImageArr[i, j] = coloration > 50 ? true : false;
                }
            }

            return monoImageArr;
        }

        private static byte[] imageToBytes(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    }
}
