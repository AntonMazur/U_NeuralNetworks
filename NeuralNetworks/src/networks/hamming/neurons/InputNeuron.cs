using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworks.src.networks.hamming.neurons
{
    public class InputNeuron
    {
        int row;
        int column;
        bool val;

        public InputNeuron(int row, int column, bool val)
        {
            this.row = row;
            this.column = column;
            this.val = val;
        }
    }
}
