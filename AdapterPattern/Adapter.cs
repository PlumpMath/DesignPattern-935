using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Adapter : NewStringCompatible
    {
        private ClassicString mString;
        public Adapter(string a)
        { 
            this.mString = new ClassicString(a);
        }
        public override string getNewString()
        {
            return mString.getClassicString();
        }
    }
}
