using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1.Models.CircuitGates
{
    public class OR : CircuitNode
    {
        // If inputs combined are 1 or 2 then value should be 1
        public override void processInput()
        {
            if (inputs.Sum() >= 1)
                value = 1;
            else
                value = 0;
        }
    }
}
