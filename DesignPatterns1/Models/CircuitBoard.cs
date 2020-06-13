using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1.Models
{
    public class CircuitBoard : IVisitable
    {
        public List<CircuitNode> circuitNodes { get; set; }
        public List<CircuitNode> inputNodes { get; set; }
        public CircuitBoard()
        {
            inputNodes = new List<CircuitNode>();
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public CircuitNode GetNode(string name)
        {
            return circuitNodes.Find(x => x.Name == name);
        }

        public void RefreshInputNodes() {
            inputNodes.Clear();

            foreach (CircuitNode circuitNode in circuitNodes)
            {
                if(circuitNode.GetType() == typeof(InputNode))
                    inputNodes.Add(circuitNode);
            }
        }
    }
}
