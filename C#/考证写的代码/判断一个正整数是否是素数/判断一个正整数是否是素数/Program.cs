using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判断一个正整数是否是素数
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            bool prime = true;
            Console.WriteLine("请输入一位正整数:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= n / 2; i++)
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            if (prime == true)
                Console.WriteLine("该数为素数:");
            else
                Console.WriteLine("该数位非素数:");
        }
    }
}
