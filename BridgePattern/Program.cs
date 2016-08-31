using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Implementor a = new ImplementorA();
            Implementor b = new ImplementorB();

            Bridger m = new MyBridger(a);
            m.operation();

            Bridger n = new MyBridger(b);
            n.operation();

            Console.ReadKey();
        }
    }
}
