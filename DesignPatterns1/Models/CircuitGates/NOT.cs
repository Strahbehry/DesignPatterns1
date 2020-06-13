using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1.Models.CircuitGates
{
    public class NOT : CircuitNode
    {
        // x = 1 -x | x = 1 - 0 | x = 1 - 1 effective way of inverting
        public override void processInput()
        {
            value = 1 - inputs[0];
        }
    }
}
