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

        public void addCheapCPU()
        {
            m_computer.add("CPU-Core-m");
        }

        public void addMemory()
        {
            m_computer.add("Memory-4GB");
        }

        public Computer getComputer()
        {
            addCheapCPU();
            addMemory();
            return m_computer;
        }
    }
}
