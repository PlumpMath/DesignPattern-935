using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class GridLayout : Layout
    {
        public override void getText()
        {
            Console.WriteLine("A grid layout.");
        }
    }
}
