using DesignPatterns1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1.Logging
{
    public class LoggingDecorator : CircuitNode
    {
        private CircuitNode _node;
        public LoggingDecorator(CircuitNode node)
        {
            _node = node;
        }
        public void inputValue(int value)
        {
            Console.WriteLine("Input value: " + value);
            _node.inputValue(value);
        }

        public List<int> inputs { get; set; }
        public int value { get; set; }
        public List<String> Edges { get; }
        public String Name { get; set; }
        public String Type { get; set; }
    }
}
