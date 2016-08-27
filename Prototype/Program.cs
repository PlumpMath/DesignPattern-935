using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] m_players = { "Kobe Bryant", "Lebron James" };
            Member players = new Member(m_players);
            string[] m_coach = { "pop" };
            Member coach = new Member(m_coach);
            BasketBallTeam protoTeam = new BasketBallTeam(players, coach);
            protoTeam.teamMsg();

            BasketBallTeam newTeam = (BasketBallTeam)protoTeam.Clone();
            newTeam.teamMsg();

            Console.ReadKey();
        }
    }
}
