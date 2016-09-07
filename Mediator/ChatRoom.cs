using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    /* 具体中介类 */
    public class ChatRoom : Ｍediator
    {
        public override void SendMsg(string msg, User user)
        {
            var newMsg = $"{msg}.   -------sender is {user.name}";
            foreach (var one in users)
            {
                if(one != user)
                one.receive(newMsg);
            }
        }
    }
}
