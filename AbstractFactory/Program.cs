using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ThemeFactory m_creator = new ThemeCreator1();
            Button button1 = m_creator.createButton();
            Layout layout1 = m_creator.createLayout();

            button1.getText();
            layout1.getText();

            Console.ReadKey();
        }
    }
}
