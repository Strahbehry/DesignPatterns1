using DesignPatterns1.Models;
using Microsoft.Msagl.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns1
{
    class DrawGraph : IVisitor
    {
        public Graph graph { get; set; }

        public DrawGraph(Graph graph)
        {
            this.graph = graph;
        }

        public void Visit(CircuitBoard circuit)
        {
            circuit.circuitNodes.ForEach(CircuitNode => drawEdges(CircuitNode));
        }

        void drawEdges(CircuitNode node)
        {
            foreach(string edgeNode in node.Edges)
            {
                var edge = graph.AddEdge(node.Name, edgeNode);
                
                if(new string[] {"A", "B", "Cin", "Cout", "S" }.Contains(node.Name))
                {
                    edge.SourceNode.LabelText = node.Name + " \n " + node.value;
                }
                else
                {
                    edge.SourceNode.LabelText = node.Type + " \n " + node.value;
                }
            }
        }
    }
}
