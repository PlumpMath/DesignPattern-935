using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /* 发布者 */
    public class ConcreteSubject : Subject
    {

        public override void notify()
        {
            foreach (var observer in observers)
            {
                observer.update();
            }
        }
    }
}
