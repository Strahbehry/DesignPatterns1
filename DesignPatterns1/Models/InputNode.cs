using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1.Models
{
    public class InputNode : CircuitNode
    {
        public override void processInput()
        {
            if (this.Type == "INPUT_HIGH")
                value = 1;
            else
                value = 0;
        }
    }
}
