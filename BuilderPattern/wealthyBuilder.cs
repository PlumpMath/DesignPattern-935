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

        public void addExpensiveCPU()
        {
            m_computer.add("CPU-i7-6790");
        }

        public void addExpensiveGPU()
        {
            m_computer.add("GPU-GT98M");
        }

        public void addMemory()
        {
            m_computer.add("Memory-16GB");
        }

        public Computer getComputer()
        {
            addExpensiveCPU();
            addExpensiveGPU();
            addMemory();
            return m_computer;
        }
    }
}
