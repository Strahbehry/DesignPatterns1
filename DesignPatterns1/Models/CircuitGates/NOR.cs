using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1.Models.CircuitGates
{
    public class NOR : CircuitNode
    {
        // If sum of inputs is 0 the value is 1 otherwise 0
        public override void processInput()
        {
            if (inputs.Sum() == 0)
                value = 1;
            else
                value = 0;
        }
    }
}
