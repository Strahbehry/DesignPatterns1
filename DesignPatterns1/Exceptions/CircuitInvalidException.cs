using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DesignPatterns1.Exceptions
{
    public class CircuitInvalidException : Exception
    {
        public CircuitInvalidException(string customMsg)
        {
            MessageBox.Show(this.GetType() + " : " + customMsg);
        }
    }
}
