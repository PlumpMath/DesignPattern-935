using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /* 具体的装饰器 */
    class ScrollBarDecorator : Decorator
    {
        public ScrollBarDecorator(View View) : base(View)
        {}

        public void whatTheFuckYouWantToDO()
        {
            Console.WriteLine("Hi I am a scroll BAR");
        }

        public override void show()
        {
            whatTheFuckYouWantToDO();
            view.show();
        }
    }
}
