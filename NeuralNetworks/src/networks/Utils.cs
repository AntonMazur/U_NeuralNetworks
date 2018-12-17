using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworks.src.networks
{
    class Utils
    {
        public static double boolToNum(bool val)
        {
            return val ? 1 : -1;
        }

        public static int boolToInt(bool val)
        {
            return val ? 1 : -1;
        }
    }
}
