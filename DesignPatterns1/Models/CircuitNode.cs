using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1.Models
{
    public class CircuitNode
    {
        public CircuitNode()
        {
            this.Edges = new List<String>();
        }

        public List<String> Edges { get; }
        public String Name { get; set; }
        public String Type { get; set; }
    }
}
