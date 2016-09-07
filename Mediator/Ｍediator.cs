using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    /* 抽象中介类 */
    public abstract class Ｍediator
    {
        public List<User> users = new List<User>();
        public abstract void SendMsg(string msg, User user);

        public void register(User User)
        {
            User.setMediator(this);
            users.Add(User);
        }
    }
}
