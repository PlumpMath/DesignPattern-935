using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var commonManager = getMyLeaders();

            var request = new Request
            {
                requsetType = "请假",
                number = 1,
            };
            commonManager.correspondRequest(request);

            var request1 = new Request
            {
                requsetType = "请假",
                number = 5,
            };
            commonManager.correspondRequest(request1);

            var request2 = new Request
            {
                requsetType = "加薪",
                number = 100,
            };
            commonManager.correspondRequest(request2);

            var request3 = new Request
            {
                requsetType = "加薪",
                number = 1000,
            };
            commonManager.correspondRequest(request3);

            Console.ReadKey();
        }

        public static Manager getMyLeaders()
        {
            var commonManager = new CommonManager("经理");
            var secondManager = new SecondManager("区域经理");
            var generalManager = new GeneralManager("总经理");

            commonManager.setLeader(secondManager);
            secondManager.setLeader(generalManager);

            return commonManager;
        }
    }
}
