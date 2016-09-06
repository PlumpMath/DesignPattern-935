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

            var ele2 = new Line();
            var ele3 = new Circle();

            var ele4 = new ComplexElement();
            var ele5 = new Line();
            var ele6 = new Circle();
            ele4.Add(ele5);
            ele4.Add(ele6);

            ele1.Add(ele4);
            ele1.Add(ele2);
            ele1.Add(ele3);

            ele1.Draw();
            Console.ReadKey();
        }
    }
}
