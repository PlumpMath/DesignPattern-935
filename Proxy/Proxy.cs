using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    /* 代理类 */
    class Proxy : Subject
    {
        private Subject subject;
        
        public Proxy(Subject Subject)
        {
            subject = Subject;
        }

        public void preRequest()
        {
            Console.WriteLine("请求之前做点事");
        }
        public void postRequest()
        {
            Console.WriteLine("请求之后做点事");
        }

        public override void request()
        {
            preRequest();
            subject.request();
            postRequest();
        }
    }
}
