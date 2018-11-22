using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworks.src.networks.hamming.neurons
{
    public class InputNeuron
    {
        double[] componentWeights;
        int componentIndex;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="samples"> Must be not empty!!! </param>
        /// <param name="componentIndex"></param>
        private InputNeuron(IEnumerable<Sample> samples, int componentIndex) 
        {
            this.componentWeights = new double[samples.First().height * samples.First().width];

            for (int i = 0; i < componentWeights.Length; i++)
            {
                componentWeights[i] = Utils.boolToNum(samples.ElementAt(i).asBitArray().Get(componentIndex)) * 0.5;
            }

            this.componentIndex = componentIndex;
        }


        public static InputNeuron[] createLayer(IEnumerable<Sample> samples)
        {
            InputNeuron[] neurons = new InputNeuron[samples.Count()];

            for (int i = 0; i < samples.Count(); i++)
            {
                neurons[i] = new InputNeuron(samples, i);
            }

            return neurons;
        }
    }
}
