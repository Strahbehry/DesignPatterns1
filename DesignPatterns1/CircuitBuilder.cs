using DesignPatterns1.Models;
using DesignPatterns1.Models.CircuitGates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    public class CircuitBuilder
    {
        NodeFactory factory;

        public CircuitBuilder()
        {
            factory = new NodeFactory();
            factory.AddNodeType<AND>();
            factory.AddNodeType<NAND>();
            factory.AddNodeType<NOR>();
            factory.AddNodeType<NOT>();
            factory.AddNodeType<OR>();
            factory.AddNodeType<XOR>();
            factory.AddNodeType<InputNode>();
            factory.AddNodeType<OutputNode>();
        }

        public CircuitBoard BuildCircuit(string[] _lines)
        {
            CircuitBoard board = new CircuitBoard();

            string[] lines = _lines;

            if(lines == null)
                return null;

            bool parseNeighbours = false;


            var nodes = new List<CircuitNode>();

            foreach (var line in lines)
            {
                if (IsDescription(line))
                {
                    parseNeighbours = true;
                    continue;
                }
                else if ((parseNeighbours && !IsComment(line))) // post-description of logic
                {
                    var split = line.Split(':');
                    var name = split[0];
                    var neighbours = split[1].Trim(';').Split(',');

                    var node = nodes.Find(x => x.Name == name);

                    foreach (var n in neighbours)
                    {
                        string clean = Regex.Replace(n, "[^A-Za-z0-9]", "");
                        var neighbourNode = nodes.Find(x => x.Name == clean);
                        node.Edges.Add(clean);

                        if (node.Type.Contains("INPUT_LOW"))
                        {
                            node.inputValue(0);
                        }
                        else if (node.Type.Contains("INPUT_HIGH"))
                        {
                            node.inputValue(1);
                        }

                        neighbourNode.inputValue(node.value);
                    }
                }
                else if (!IsComment(line) && line != "") // pre-description of logic
                {
                    string[] split = line.Split(':');


                    string name = split[0].Trim();
                    string type = split[1].Trim(';').Trim();

                    INodeSelectionStrategy strategy;

                    if (SpecialNodeSelectionStrategy.types.Contains(type.ToUpper()))
                    {
                        strategy = new SpecialNodeSelectionStrategy();
                    }
                    else
                    {
                        strategy = new DefaultNodeSelectionStrategy();
                    }

                    var node = factory.Create(strategy.GetNodeType(type));
                    node.Name = name;
                    node.Type = type;

                    nodes.Add(node);
                }
            }

            board.circuitNodes = nodes;
            return board;
        }

        private bool IsComment(string line)
        {
            if (line.StartsWith("#"))
            {
                return true;
            }
            return false;
        }

        private bool IsDescription(string line)
        {
            return line.Equals("# Description of all the edges");
        }
    }
}
