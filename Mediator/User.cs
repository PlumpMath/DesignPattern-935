using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    /* 实际使用的很多类的公共抽象父类 */
    public abstract class User
    {
        public User(string Name)
        {
            name = Name;
        }
        public string name { get; set; }

        protected Ｍediator chatRoom;

        public abstract void send(string msg);

        public abstract void receive(string msg);

        public void setMediator(Ｍediator Mediator)
        {
            chatRoom = Mediator;
        }
    }
}
