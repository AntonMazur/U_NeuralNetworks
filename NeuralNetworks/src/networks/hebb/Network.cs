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

        private static double[,] learn(Sample[] samples, HebbSample[] hSamples)
        {
            int sampleLen = samples[0].area;
            HebbSample.resetState();
            HebbSample.digitCount = (int)Math.Ceiling(Math.Log(samples.Length, 2));
            double[,] weights = new double[HebbSample.digitCount, sampleLen];  // row - weights of edges from inputs to first neuron, column - weights of edges from the input to all neurons


            for (int k = 0; k < samples.Length; k++)
            {
                var sampleArr = samples[k].asBitArray();
                bool failOccured;

                do
                {
                    failOccured = false;

                    for (int i = 0; i < HebbSample.digitCount; i++)
                    {
                        var output = 0d;

                        for (int j = 0; j < sampleLen; j++)
                        {
                            output += weights[i, j] * Utils.boolToNum(sampleArr[j]);
                        }

                        output = output > 0 ? 1 : -1;

                        if (output * hSamples[i].getNeuronOutput(i) < 0)
                        {
                            failOccured = true;

                            for (int j = 0; j < sampleLen; j++)
                            {
                                weights[i, j] = getWeightDelta(Utils.boolToNum(sampleArr[j]), output);
                            }
                        }

                    }
                } while (failOccured);

            }

            return weights;
        }

        private static double getWeightDelta(double input, double output)
        {
            if (input == 0) return 0;

            return input * output > 0 ? 1 : -1;
        }
    }

    struct HebbSample
    {
        public static int digitCount = 0;
        public static int counter = 0;
        private Sample sample;
        private double[] networkOutput;

        public HebbSample(Sample sample)
        {
            this.sample = sample;
            this.networkOutput = getNextSampleOutput();
        }

        public double getNeuronOutput(int neuronNum)
        {
            return Utils.boolToNum(((counter >> neuronNum) & 1) == 1);
        }

        public static void resetState()
        {
            digitCount = 0;
            counter = 0;
        }

        public static HebbSample[] convertAll(Sample[] samples)
        {
            return samples.Select(s => new HebbSample(s)).ToArray();
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
