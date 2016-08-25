using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Configer m_configer = Configer.getInstance();
            m_configer.getConfig();
            Console.ReadKey();
        }
    }
}
