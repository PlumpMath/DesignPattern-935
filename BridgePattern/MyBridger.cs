using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class MyBridger : Bridger
    {
        public MyBridger(Implementor imp) : base(imp)
        {}

        public override void operation()
        {
            _imp.operation();
        }
    }
}
