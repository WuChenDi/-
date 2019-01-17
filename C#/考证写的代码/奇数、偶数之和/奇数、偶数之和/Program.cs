using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 奇数_偶数之和
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, result;
            result = 0;
            Console.WriteLine("请输入一个正整数:");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
                for (i = 2; i <= n; i += 2)
                    result += i;
            else
                for (i = 1; i <= n; i += 2)
                    result += i;
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
