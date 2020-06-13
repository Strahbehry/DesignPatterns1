using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1.Models.CircuitGates
{
    public class XOR : CircuitNode
    {
        // if inputs are 0+1 or 1+0 the value will be 1 in 0+0 or 1+1 it will be 0
        public override void processInput()
        {
            if (inputs.Sum() == 1)
                value = 1;
            else
                value = 0;
        }
    }
}
