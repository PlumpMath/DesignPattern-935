using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ThemeCreator2 : ThemeFactory
    {
        public override Button createButton()
        {
            return new RedButton();
        }

        public override Layout createLayout()
        {
            return new StackLayOut();
        }
    }
}
