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
    public sealed class Fileparser
    {
        CircuitBoard circuitBoard;
        private static Fileparser instance = null;
        private static readonly object padlock = new object();
        private CircuitBuilder circuitBuilder;

        Fileparser()
        {
            circuitBoard = new CircuitBoard();
            circuitBuilder = new CircuitBuilder();
        }

        public static Fileparser Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Fileparser();
                    }
                }
                return instance;
            }
        }

        public CircuitBoard ParseCircuit(string[] _lines)
        {
            circuitBoard = circuitBuilder.BuildCircuit(_lines);

            return circuitBoard;
        }
    }
}
