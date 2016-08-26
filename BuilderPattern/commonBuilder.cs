using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class commonBuilder:IBuilder
    {
        private Computer m_computer = new Computer();

        public void chooseCPU()
        {
            m_computer.add("CPU-Core-m");
        }

        public void chooseGPU()
        {
            m_computer.add("GPU-Intel3000");
        }

        public void chooseMemory()
        {
            m_computer.add("Memory-4GB");
        }

        public Computer getProduct()
        {
            return m_computer;
        }
    }
}
