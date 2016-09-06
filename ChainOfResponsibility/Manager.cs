using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    /* 职责链上所有响应请求的类的抽象父类 */
    public abstract class Manager
    {
        protected string name;

        protected Manager leader;

        public Manager(string Name)
        {
            name = Name;
        }

        public void setLeader(Manager manager)
        {
            leader = manager;
        }

        /* 响应请求的抽象方法 */
        public abstract void correspondRequest(Request request);
    }
}
