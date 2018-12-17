using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuralNetworks.src.networks.hamming.neurons;

namespace NeuralNetworks.src.networks.hamming
{
    public class Network
    {
        public static Sample run(Sample[] samples, Sample testSample)
        {
            var firstLawerWeights = Sample.toWeightArray(samples);
            var zNeurons = new ZNeuron[samples.Length];
            ZNeuron.setK(1d/testSample.area);

            for (int i = 0; i < samples.Length; i++)
            {
                zNeurons[i] = new ZNeuron(firstLawerWeights, i);
            }

            return samples[ZNeuron.getDominateSample(zNeurons, testSample)];
        }

    }
}
