using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Operation
    {
        private double _numA;
        private double _numB;
        public double numA
        {
            get { return _numA; }
            set { _numA = Convert.ToDouble(value); }
        }
        public double numB
        {
            get { return _numB; }
            set { _numB = Convert.ToDouble(value);  }
        }

        public virtual double getResult()
        {
            return 0;
        }
    }
}
