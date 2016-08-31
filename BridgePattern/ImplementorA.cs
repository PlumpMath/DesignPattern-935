using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class ImplementorA : Implementor
    {
        public override void operation()
        {
            Console.WriteLine("I am implementor A and this is my operation.");
        }
    }
}
