using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var m_de = new ScrollBarDecorator(new TextView());
            m_de.show();

            Console.ReadKey();
        }
    }
}
