using DesignPatterns1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    class NodeFactory
    {
        Dictionary<string, Type> nodeTypes = new Dictionary<string, Type>();

        public NodeFactory AddNodeType<TNode>(string name = null) where TNode : CircuitNode
        {
            var type = typeof(TNode);
            nodeTypes.Add(name ?? type.Name, typeof(TNode));
            return this;
        }

        public CircuitNode Create(string nodeType)
        {
            if (nodeTypes.TryGetValue(nodeType, out var type))
            {
                return Activator.CreateInstance(type) as CircuitNode;
            }
            return null;
        }

        public CircuitNode createDecorator(CircuitNode node)
        {
            CircuitNode loggingDeco = new Logging.LoggingDecorator(node);
            return loggingDeco;
        }

    }
}
