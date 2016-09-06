using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Circle : GraphicElement
    {
        public Circle()
        {
            name = "Circle";
        }

        public override void Draw()
        {
            Console.WriteLine("I am a {0}.", name);
        }
    }
}
