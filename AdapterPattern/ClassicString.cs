using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class ClassicString
    {
        private string _internString = null;

        public ClassicString(string a)
        {
            _internString = a;
        }
        public string getClassicString()
        {
            return _internString;
        }
    }
}
