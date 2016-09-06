using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class GraphicElement
    {
        public string name { get; set; }
        public GraphicElement(String Name)
        {
            name = Name;
        }

        public GraphicElement()
        {
            name = "Anonymous Graphic Element";
        }

        public abstract void Draw();
    }
}
