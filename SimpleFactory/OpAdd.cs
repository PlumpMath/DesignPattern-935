﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class OpAdd:Operation
    {
        public override double getResult()
        {
            return numA + numB;
        }
    }
}
