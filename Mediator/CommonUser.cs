using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    /* 具体类 */
    public class CommonUser : User
    {
        public CommonUser(string Name) : base(Name)
        {
        }

        public override void receive(string msg)
        {
            Console.WriteLine($"User - {name} receives message: {msg}");
        }

        public override void send(string msg)
        {
            chatRoom.SendMsg(msg, this);
        }
    }
}
