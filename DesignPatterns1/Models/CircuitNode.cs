using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DesignPatterns1.Models
{
    public abstract class CircuitNode
    {
        public CircuitNode()
        {
            inputs = new List<int>();
            this.Edges = new List<String>();
        }

        public void inputValue(int value)
        {
            inputs.Add(value);
            
            processInput();
        }

        // This is the method we'll be overriding to get seperate behaviour for nodes
        public virtual void processInput()
        {
            value = inputs[0];
        }

        public List<int> inputs { get; set; }
        public int value { get; set; }
        public List<String> Edges { get; }
        public String Name { get; set; }
        public String Type { get; set; }
    }
}
