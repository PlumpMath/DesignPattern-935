using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class GeneralManager : Manager
    {
        public GeneralManager(string name) : base(name)
        {
        }

        public override void correspondRequest(Request request)
        {
            if (request.requsetType == "请假")
            {
                Console.WriteLine($"{name}:{request.requsetType},数量{request.number},被批准");
            }
            else if (request.requsetType == "加薪" && request.number <= 500)
            {
                Console.WriteLine($"{name}:{request.requsetType},数量{request.number},被批准");
            }
            else
            {
                Console.WriteLine($"{name}:{request.requsetType},数量{request.number},不通过");
            }
        }
    }
}
