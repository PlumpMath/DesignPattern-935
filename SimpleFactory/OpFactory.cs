using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class OpFactory
    {
        public static Operation createOp(string op)
        {
            Operation res = null;
            switch(op)
            {
                case "+":
                    res = new OpAdd();
                    break;
                case "-":
                    res = new OpSub();
                    break;
                case "*":
                    res = new OpMul();
                    break;
                case "/":
                    res = new OpDiv();
                    break;
            }
            return res;
        }
    }
}
