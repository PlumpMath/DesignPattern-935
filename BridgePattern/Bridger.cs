using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Bridger
    {
        protected Implementor _imp;

        public Bridger(Implementor imp)
        {
            _imp = imp;
        }

        public virtual void operation()
        {}
    }
}
