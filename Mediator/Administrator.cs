using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    /* 具体类 */
    public class Administrator : User
    {
        public Administrator(string Name) : base(Name)
        {
        }

        public override void receive(string msg)
        {
            Console.WriteLine($"[Admin - {name}] receives message: {msg}");
            Console.WriteLine("Careful, big brother is watching UUUU");
        }

        public override void send(string msg)
        {
            chatRoom.SendMsg(msg, this);
        }
    }
}
