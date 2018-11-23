using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworks.src.networks.hamming.neurons
{
    class ZNeuron
    {
        private double[] sample;
        private int sampleIndex;
        private double lastState;
        private static double k;
        private static int maxIter = 10;


        public ZNeuron(double[,] inputWeights, int sampleIndex) {
            sample = new double[inputWeights.GetLength(1)];

            for (int i = 0; i < sample.Length; i++)
            {
                sample[i] = inputWeights[sampleIndex, i];
            }

            this.sampleIndex = sampleIndex;
        }

        public static void setK(double k)
        {
            ZNeuron.k = k;
        }

        private void sendSignal(Sample testSample)
        {
            var testSampleArr = testSample.asBitArray();
            double state = testSampleArr.Length / 2;

            for (int i = 0; i < testSampleArr.Length; i++)
            {
                state += sample[i] * Utils.boolToNum(testSampleArr[i]);
            }

            this.lastState = applyActivationFunc(state);
        }

        private double applyActivationFunc(double input)
        {
            var threshold = 1 / k;
            return input < 0 ? 0 : (input < threshold ? input * k : threshold);
        }

        public static int getDominateSample(ZNeuron[] neurons, Sample testSample)
        {
            foreach (ZNeuron n in neurons) n.sendSignal(testSample);
            
            double eps = 1 / neurons.Length;
            double[] prevLayerState;
            double[] currLayerState;
            int iter = 0;

            do
            {
                prevLayerState = extractLayerState(neurons);

                foreach (ZNeuron n in neurons)
                {
                    n.computeNewState(prevLayerState, eps);
                }

                currLayerState = extractLayerState(neurons);

            } while (!prevLayerState.SequenceEqual(currLayerState) && ++iter < maxIter);

            var dominateSampleIdx = -1;
            var maxStateValue = -1d;

            for (int i = 0; i < currLayerState.Length; i++)
            {
                if (currLayerState[i] > maxStateValue)
                {
                    maxStateValue = currLayerState[i];
                    dominateSampleIdx = i;
                }
            }

            return dominateSampleIdx;
        }

        private void computeNewState(double[] layerState, double eps)
        {
            var otherNeuronsImpact = 0d;
            for (int i = 0; i < layerState.Length; i++)
            {
                if (i != sampleIndex)
                {
                    otherNeuronsImpact += layerState[i];
                }
            }

            this.lastState = applyActivationFunc(this.lastState - eps * otherNeuronsImpact); 
        }

        private static double[] extractLayerState(ZNeuron[] neurons)
        {
            double[] layerState = new double[neurons.Length];

            for (int i = 0; i < neurons.Length; i++)
            {
                layerState[i] = neurons[i].lastState;
            }

            return layerState;
        }
    }
}
