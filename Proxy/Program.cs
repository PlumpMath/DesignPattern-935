using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var mProxy = new Proxy(new realSubject());

            mProxy.request();

            Console.ReadKey();
        }
    }
}
