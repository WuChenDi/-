using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算两个正整数的最大公约数
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, result, temp;
            result = 1;
            Console.WriteLine("请输入第一个正整数;");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个正整数:");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
                temp = b;
            else
                temp = a;
            Console.WriteLine("最大的公约数为:");
            for (i = temp; i >= 1; i--)
                if (a % i == 0 && b % i == 0)
                {
                    result = i;
                    Console.WriteLine(result);
                    break;
                }
            Console.ReadLine();

        }
    }
}
