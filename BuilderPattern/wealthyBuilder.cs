using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class wealthyBuilder : IBuilder
    {
        private Computer m_computer = new Computer();

        public void chooseCPU()
        {
            m_computer.add("CPU-i7-6790");
        }

        public void chooseGPU()
        {
            m_computer.add("GPU-GT98M");
        }

        public void chooseMemory()
        {
            m_computer.add("Memory-16GB");
        }

        public Computer getProduct()
        {
            return m_computer;
        }
    }
}
