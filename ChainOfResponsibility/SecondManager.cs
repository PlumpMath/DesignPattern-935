using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class SecondManager : Manager
    {
        public SecondManager(string name) : base(name)
        {
        }

        public override void correspondRequest(Request request)
        {
            if (request.requsetType == "请假" && request.number <= 10)
            {
                Console.WriteLine($"{name}:{request.requsetType},数量{request.number},被批准");
            }
            else
            {
                leader?.correspondRequest(request);
            }
        }
    }
}
