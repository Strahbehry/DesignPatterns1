using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DesignPatterns1.Exceptions;
using DesignPatterns1.Models;

namespace DesignPatterns1.Validators
{
    class NoDeadEndValidator : IVisitor
    {
        CircuitBoard circuit;
        List<CircuitNode> inputNodes;

        public NoDeadEndValidator(CircuitBoard circuit)
        {
            this.circuit = circuit;
            circuit.RefreshInputNodes();
            this.inputNodes = circuit.inputNodes;
        }
        public void Visit(CircuitBoard circuit)
        {
            // Choosing to only throw a exception and warn the user that the board is unusable because technically boards with infinite loops can be made
            // They just can't be used

            foreach (var node in inputNodes)
            {
                visitRecursively(new List<string>(), node);
            }
        }

        public void visitRecursively(List<string> path, CircuitNode node)
        {
            path.Add(node.Name);
            foreach (string s in node.Edges)
            {
                var currentNode = circuit.circuitNodes.Find(x => x.Name == s);
                // We have to copy the list or we might get false positives when inputnodes are connected to a AND get from the get-go
                var copyList = new List<string>();
                copyList.AddRange(path);

                checkIfEmptyAndNotOutputNode(currentNode);
                visitRecursively(copyList, currentNode);
            }
        }

        public void checkIfEmptyAndNotOutputNode(CircuitNode node)
        {
            if (node.Edges.Count == 0 && node.GetType() != typeof(OutputNode))
            {
                throw new CircuitInvalidException(" there is a dead-end in the circuit it is invalid and the node values may be incorrect");
            }
        }
    }
}
