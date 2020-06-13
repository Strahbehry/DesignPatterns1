using DesignPatterns1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    interface INodeSelectionStrategy
    {
        String GetNodeType(String type); 
    }
}
