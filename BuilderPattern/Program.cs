using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director m_director = new Director();
            IBuilder wealthyBuilder = new wealthyBuilder();
            IBuilder commonBuilder = new commonBuilder();

            m_director.setBuilder(wealthyBuilder);
            Computer m_computer = m_director.construct();
            m_computer.show();

            m_director.setBuilder(commonBuilder);
            Computer m_computer2 = m_director.construct();
            m_computer2.show();

            Console.ReadKey();
        }
    }
}
