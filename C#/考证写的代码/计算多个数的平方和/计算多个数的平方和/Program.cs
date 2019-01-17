using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算多个数的平方和
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, total = 0;
            string s_input;
            Console.WriteLine("请依次输入样本值，输入X结束");
            s_input = Console.ReadLine();
            while (!(Convert.ToChar(s_input) == 'x' || Convert.ToChar(s_input) == 'X'))
            {
                a = float.Parse(s_input);
                total += a * a;
                s_input = Console.ReadLine();
            }
            Console.WriteLine("平方和为:");
            Console.WriteLine(total);
        }
    }
}
