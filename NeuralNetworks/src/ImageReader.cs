using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworks.src
{
    class ImageReader
    {
        public static Image read(String path)
        {
            return Image.FromFile(@path);
        }


        public static MonoImage readMono(String path, int width, int height)
        {
            var image = read(path);
            return new MonoImage(image, width, height);
        }

        
    }
}
