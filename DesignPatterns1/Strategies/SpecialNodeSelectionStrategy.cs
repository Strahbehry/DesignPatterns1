using DesignPatterns1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    class SpecialNodeSelectionStrategy : INodeSelectionStrategy
    {
        public static string[] types = new string[] { "PROBE", "INPUT_HIGH", "INPUT_LOW" };
        public String GetNodeType(string type)
        {
            if (type.ToUpper() == "PROBE")
                return "OutputNode";
            else if (type.ToUpper() == "INPUT_HIGH" || type.ToUpper() == "INPUT_LOW")
                return "InputNode";

            return null;
        }
    }
}
