using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1.Models.CircuitGates
{
    public class AND : CircuitNode
    {
        // The sum will only be 2 if both inputs given are 1
        public override void processInput()
        {
            if (inputs.Sum() == inputs.Count())
                value = 1;
            else
                value = 0;
        }
    }
}
