using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /* 装饰器抽象父类 */
    abstract class Decorator
    {
        protected View view;

        public Decorator(View View)
        {
            view = View;
        }

        /* 装饰函数 */
        public abstract void show();
    }
}
