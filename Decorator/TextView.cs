using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /* 待装饰的具体类 */
    public class TextView : View
    {

        public override void show()
        {
            Console.WriteLine("Hi I am a TextView");
        }
    }
}
