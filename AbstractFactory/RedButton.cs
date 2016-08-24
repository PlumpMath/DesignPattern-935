using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class RedButton : Button
    {
        public override void getText()
        {
            Console.WriteLine("I am a red button.");
        }
    }
}
