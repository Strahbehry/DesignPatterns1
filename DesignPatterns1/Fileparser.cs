using DesignPatterns1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    public class Fileparser
    {
        public Fileparser()
        {

        }

        public List<CircuitNode> ParseCircuit(string[] _lines)
        {
            string[] lines = _lines;
            bool parseNeighbours = false;


            var nodes = new List<CircuitNode>();

            foreach (var line in lines)
            {
                if (IsDescription(line))
                {
                    parseNeighbours = true;
                    continue;
                }
                else if ((parseNeighbours && !IsComment(line)))
                {
                    var split = line.Split(':');
                    var name = split[0];
                    var neighbours = split[1].Trim(';').Split(',');

                    var node = nodes.Find(x => x.Name == name);

                    foreach (var n in neighbours)
                    {
                        node.Edges.Add(n);
                    }
                }
                else if (!IsComment(line))
                {
                    string[] split = line.Split(':');
                    nodes.Add(new CircuitNode()
                    {
                        Name = split[0].Trim(),
                        Type = split[1].Trim(';').Trim()
                    });
                }
            }

            return nodes;
        }

        private bool IsComment(string line)
        {
            return line[0] == '#';
        }

        private bool IsDescription(string line)
        {
            return line.Equals("# Description of all the edges");
        }
    }
}
