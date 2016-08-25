using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Configer
    {
        private static volatile Configer _configer = null;
        private static object _lock = new object();
        private Configer() { }

        public static Configer getInstance()
        {
            if (_configer == null)
            {
                lock(_lock)
                {
                        if (_configer == null)
                        { 
                            _configer = new Configer();
                        }
                }
                
            }
            return _configer;
        }

        public void getConfig()
        {
            Console.WriteLine("I am a singeton object and i am reading config");
        }
    }
}
