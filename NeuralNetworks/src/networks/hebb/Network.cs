using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworks.src.networks.hebb
{
    class Network
    {
        private static HebbSample[] canonicalSamples;
        private static int[,] resWeights;

        public static Sample run(Sample[] samples, Sample testSample)
        {
            var len = testSample.area;
            var binTestSample = testSample.asBitArray();
            var idx = 0;
            var posReactCount = 0;

            for (int i = 0; i < resWeights.GetLength(0); i++)
            {
                var res = resWeights[i, resWeights.GetLength(1) - 1];
                for (int j = 0; j < resWeights.GetLength(1) - 1; j++)
                {
                    res += resWeights[i, j] * (Utils.boolToInt(binTestSample[j]) + 1) / 2;
                }
                if (res > 0)
                {
                    posReactCount++;
                    idx = i;
                }
            }

            
                return canonicalSamples[idx].getPrimeSample();
            
            
         }

        public static Sample run(Sample[] samples, string weightsFile, Sample testSample)
        {
            //double[,] weights = readWeightsFromFile(weightsFile);

            throw new NotImplementedException("No implementation for hebb network");

        }

        public static void learn(Sample[] samples)
        {
            HebbSample.resetState();
            HebbSample.digitCount = samples.Length;
            var hSamples = HebbSample.convertAll(samples);
            int sampleLen = samples[0].area;
            int[,] weights = new int[HebbSample.digitCount, sampleLen + 1];  // row - weights of edges from inputs to first neuron, column - weights of edges from the input to all neurons
            int iter = 0;
            for (iter = 0; iter < 1000; iter++)
            {
                for (int k = 0; k < samples.Length; k++)
                {
                    var sampleArr = samples[k].asBitArray();
                    bool failOccured;

                    do
                    {
                        failOccured = false;

                        for (int i = 0; i < HebbSample.digitCount; i++)
                        {

                            var output = 0;

                            for (int j = 0; j < sampleLen; j++)
                            {
                                output += weights[i, j] * Utils.boolToInt(sampleArr[j]);
                            }

                            output += weights[k, sampleLen];

                            output = output > 0 ? 1 : -1;

                            var properOutput = hSamples[k].getNeuronOutput(i);

                            if (output != properOutput)
                            {
                                failOccured = true;

                                for (int j = 0; j < sampleLen; j++)
                                {
                                    weights[i, j] += getWeightDelta(Utils.boolToInt(sampleArr[j]), properOutput);
                                }

                                weights[i, sampleLen] += properOutput;
                            }

                        }
                    } while (failOccured);
                    
                }

            }
            canonicalSamples = hSamples;
            resWeights = weights;

        }

        //private static modifyWeights(int neuronNum, int[] sample, int[,] weights)

        private static int getWeightDelta(int input, int output)
        {
            if (input == 0) return 0;

            return input * output > 0 ? 1 : -1;
        }

        private static double[,] readWeightsFromFile(string file)
        {
            var fileTokens = File.ReadAllLines(file)
                .Select(line => line.Split(' ')
                .Select(token => token).ToArray()).ToArray();

            var weights = new double[fileTokens.Length, fileTokens[0].Length];

            for (int i = 0; i < fileTokens.Length; i++)
                for (int j = 0; j < fileTokens[0].Length; j++)
                    weights[i, j] = double.Parse(fileTokens[i][j]);

            return weights;
        }
    }

    struct HebbSample
    {
        public static int digitCount = 0;
        public static int counter = 0;
        private Sample sample;
        private int[] networkOutput;

        public HebbSample(Sample sample)
        {
            this.sample = sample;
            this.networkOutput = getNextSampleOutput();
        }

        public int getNeuronOutput(int neuronNum)
        {
            return networkOutput[neuronNum];
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

        public Sample getPrimeSample() { return sample; }

        private static int[] getNextSampleOutput()
        {
            var result = new int[digitCount];

            result = result.Select(v => -1).ToArray();
            result[counter++] = 1;

            return result;
        }

    }
}
