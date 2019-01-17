using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 求一个数所有的公约数
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("请输入一个正整数:");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 != 0)
            {
                for (i = 3; i <= (n - 1) / 2; i++)
                    if (n % i == 0)
                        Console.WriteLine(i);
            }
            else
            {
                for (i = 2; i <= n / 2; i++)
                    if (n % i == 0)
                        Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
