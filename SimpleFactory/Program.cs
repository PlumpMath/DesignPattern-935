using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "简单工厂模式";
            Console.WriteLine("加减乘除：+-*/");
            Console.WriteLine("请输入运算法则：");
            string oper = Console.ReadKey().KeyChar.ToString();
            Operation m_op = OpFactory.createOp(oper);

            Console.WriteLine("\n请输入第一个数字：");
            m_op.numA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n请输入第二个数字：");
            m_op.numB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("最后的结果是" + m_op.getResult() + "\n按任意键结束");
            Console.ReadKey();
        }
    }
}
