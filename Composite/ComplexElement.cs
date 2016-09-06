using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class ComplexElement : GraphicElement
    {
        private List<GraphicElement> childs = new List<GraphicElement>();
        public ComplexElement()
        {
            name = "Complex Element";
        }

        public void Add(GraphicElement child)
        {
            childs.Add(child);
        }

        public void Remove(GraphicElement child)
        {
            childs.Remove(child);
        }

        public override void Draw()
        {
            Console.WriteLine("I am a {0}.", name);
            Console.WriteLine("---------------------The following is my composites-----------------------");
            foreach (var child in childs)
            {
                child.Draw();
                Console.WriteLine("-----------------------");
            }
            Console.WriteLine("Done.");
        }


    }
}
