using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NeuralNetworks.src.networks.hamming
{
    class Sample
    {
        string description;
        bool[,] imgArr;
        int width;
        int height;

        public Sample(string description, bool[,] imgArr)
        {
            this.description = description;
            this.imgArr = imgArr;
            this.width = imgArr.GetLength(1);
            this.height = imgArr.GetLength(0);
        }

        public override string ToString()
        {
            var strBoolArr = new StringBuilder(height * width);

            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    strBoolArr.Append(imgArr[i, j] ? "1" : "0");

            return description.Length + " " + description + " " + height + " " + width + " " + strBoolArr.ToString() + "\n";
        }

        public static Sample FromString(string str)
        {
            int descLength = readFirstInt(str);
            string withoutLength = str.Substring(str.IndexOf(' ') + 1);
            string desc = withoutLength.Substring(0, descLength);
            string withoutDesc = withoutLength.Substring(descLength + 1);
            string[] restParams = withoutDesc.Split(' ');
            int height = int.Parse(restParams[0]);
            int width = int.Parse(restParams[1]);
            bool[,] imageArr = new bool[height, width];

            int row = 0;
            int col = 0;

            foreach (char binVal in restParams[2])
            {
                imageArr[row, col++] = binVal == '1';
                
                if (col == width)
                {
                    col = 0;
                    row++;
                }
            }

            return new Sample(desc, imageArr);
        }

        private static int readFirstInt(string source)
        {
            return int.Parse(Regex.Match(source, @"\d+").Value);
        }
    }
}
