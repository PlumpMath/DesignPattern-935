using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    /* 中介者模式的一个发送消息和接收消息的场景 */
    class Program
    {
        static void Main(string[] args)
        {
            var chatRoom = new ChatRoom();

            var user1 = new CommonUser("小明");
            var user2 = new GoldenUser("小豪");
            var user3 = new Administrator("小蛤");

            chatRoom.register(user1);
            chatRoom.register(user2);
            chatRoom.register(user3);

            user1.send("Hello,world");
            user2.send("买辆兰博基尼怎么样");
            user3.send("开门，快递");

            Console.ReadKey();
        }
    }
}
