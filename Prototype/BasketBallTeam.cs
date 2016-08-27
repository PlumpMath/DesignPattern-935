using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class BasketBallTeam : ICloneable
    {
        private Member member;
        private Member coach;
        public BasketBallTeam(Member m, Member c)
        {
            member = m;
            coach = c;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void teamMsg()
        {
            Console.WriteLine("Team Members:");
            member.show();
            Console.WriteLine("Team Coach:");
            coach.show();
        }
    }
}
