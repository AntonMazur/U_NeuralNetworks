using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworks.src.networks.hebb
{
    class Network
    {
        public static Sample run(Sample[] samples, Sample testSample)
        {
            throw new NotImplementedException("No implementation for hebb network");
        }
    }

    struct HebbSample
    {
        public static int digitCount = 0;
        public static int counter = 0;
        private Sample sample;
        private double[] networkOutput;

        HebbSample(Sample sample)
        {
            this.sample = sample;
            this.networkOutput = getNextSampleOutput();
        }

        private static double[] getNextSampleOutput()
        {
            var result = new double[digitCount];

            for (int i = 0; i < digitCount; i++)
                result[i] = Utils.boolToNum(((counter >> i) & 1) == 1);

            counter++;

            return result;
        }
    }
}
