using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Member
    {
        public List<string> members = new List<string>();

        public Member(string[] a)
        {
            foreach (var member in a)
                members.Add(member);
        }

        public void show()
        {
            foreach(var member in members)
            {
                Console.WriteLine(member + " | ");
            }
            Console.WriteLine();
        }
    }
}