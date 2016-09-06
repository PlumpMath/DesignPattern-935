using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var ele1 = new ComplexElement();

            var ele2 = new ComplexElement();
            ele2.Add(new Line());
            ele2.Add(new Circle());

            ele1.Add(new Line());
            ele1.Add(ele2);
            ele1.Add(new Circle());

            ele1.Draw(0);
            Console.ReadKey();
        }
    }
}
