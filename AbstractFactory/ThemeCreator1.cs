using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ThemeCreator1 : ThemeFactory
    {
        public override Button createButton()
        {
            return new BlueButton();
        }

        public override Layout createLayout()
        {
            return new GridLayout();
        }
    }
}
