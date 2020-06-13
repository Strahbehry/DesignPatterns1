using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DesignPatterns1.Models;
using DesignPatterns1.Exceptions;

namespace DesignPatterns1.Validators
{
    class InfiniteLoopValidator : IVisitor
    {
        CircuitBoard circuit;
        List<CircuitNode> inputNodes;

        public InfiniteLoopValidator(CircuitBoard circuit)
        {
            this.circuit = circuit;
            circuit.RefreshInputNodes();
            this.inputNodes = circuit.inputNodes;
        }
        public void Visit(CircuitBoard circuit)
        {

            foreach (var node in inputNodes)
            {
                visitRecursively(new List<string>(), node);
            }
        }

        public void visitRecursively(List<string> path, CircuitNode node)
        {
            if (path.Contains(node.Name))
            {
                throw new InfiniteLoopException("node values are incorrect, board unusable");
            }
            path.Add(node.Name);
            foreach (string s in node.Edges)
            {
                var currentNode = circuit.circuitNodes.Find(x => x.Name == s);
                // We have to copy the list or we might get false positives when inputnodes are connected to a AND get from the get-go
                var copyList = new List<string>();
                copyList.AddRange(path);

                visitRecursively(copyList, currentNode);
            }
        }
    }
}
