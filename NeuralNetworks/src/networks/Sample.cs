using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NeuralNetworks.src.networks
{
    public class Sample
    {
        public readonly string description;
        public readonly bool[,] imgArr;
        private BitArray flattenImgArr;
        public readonly int width;
        public readonly int height;
        public readonly int area;

        public Sample(string description, bool[,] imgArr)
        {
            this.description = description;
            this.imgArr = imgArr;
            this.width = imgArr.GetLength(1);
            this.height = imgArr.GetLength(0);
            this.flattenImgArr = toBitArray();
            this.area = width * height;
        }

        public override string ToString()
        {
            var strBoolArr = new StringBuilder(height * width);

            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    strBoolArr.Append(imgArr[i, j] ? "1" : "0");

            return description.Length + " " + description + " " + height + " " + width + " " + strBoolArr.ToString() + Environment.NewLine;
        }

        public BitArray asBitArray() { return flattenImgArr; }

        private BitArray toBitArray()
        {
            var res = new BitArray(width * height);

            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    res.Set(i * width + j, imgArr[i, j]);

            return res;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="samples"></param>
        /// <returns> Row of result array - is a sample, column - is a component values of different samples </returns>
        public static double[,] toWeightArray(Sample[] samples)
        {
            if (samples.Length == 0) return new double[0, 0];

            double[,] weights = new double[samples.Length, samples[0].area];

            for (int i = 0; i < samples.Length; i++)
            {
                var sampleArray = samples[i].asBitArray();
                for (int j = 0; j < samples[0].area; j++)
                {
                    weights[i, j] = Utils.boolToNum(sampleArray.Get(j));
                }
            }

            return weights;
        }

    }
}
