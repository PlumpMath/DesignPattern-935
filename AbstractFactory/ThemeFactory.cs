using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class ThemeFactory
    {
        public abstract Button createButton();
        public abstract Layout createLayout();
    }
}
