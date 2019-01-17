using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算两个正整数的最小公倍数
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, result = 1, temp;
            Console.WriteLine("请输入第一个整数:");
            a = int.Parse (Console.ReadLine());
            Console.WriteLine("请输入第二个整数:");
            b = int.Parse (Console.ReadLine());
            if (a > b)
                temp = b;
            else
                temp = a;
            Console.WriteLine("最小公倍数为:");
            for (i = temp; i <= a * b; i++)
                if (i % a == 0 && i % b == 0)
                {
                    result = i;
                    Console.WriteLine(result);
                    break;
                }
            Console.ReadLine();           
         }
    }
}
