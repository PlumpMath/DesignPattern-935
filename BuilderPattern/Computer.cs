using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Computer
    {
        private List<String> parts = new List<string>();
        public void add(string part)
        {
            parts.Add(part);
        }
        public void show()
        {
            foreach(var part in parts)
            {
                Console.WriteLine(part + " | ");
            }
        }
    }
}
