using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Director
    {
        private IBuilder m_builder = null;
        public void setBuilder(IBuilder builder)
        {
            m_builder = builder;
        }

        public Computer construct()
        {
            Console.WriteLine("director is building-------");
            m_builder.chooseCPU();
            m_builder.chooseGPU();
            m_builder.chooseMemory();
            return m_builder.getProduct();
        }
    }
}
