using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DesignPatterns1.Exceptions
{
    public class InfiniteLoopException : Exception
    {
        public InfiniteLoopException(string customMsg)
        {
            MessageBox.Show(this.GetType() + " : " + customMsg);
        }
    }
}
