using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    /* 实际请求类 */
    class realSubject : Subject
    {
        public override void request()
        {
            Console.WriteLine("a normal request");
        }
    }
}
