using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    class DefaultNodeSelectionStrategy : INodeSelectionStrategy
    {
        public String GetNodeType(string type)
        {
            return type;
        }
    }
}
