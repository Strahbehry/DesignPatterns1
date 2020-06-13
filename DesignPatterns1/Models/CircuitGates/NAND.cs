using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1.Models.CircuitGates
{
    public class NAND : CircuitNode
    {
        // The sum will only be 2 if both inputs given are 1 then value is 0 otherwise input is 1
        public override void processInput()
        {
            if (inputs.Sum() == 2)
                value = 0;
            else
                value = 1;
        }
    }
}
