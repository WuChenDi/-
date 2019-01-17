using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一章全部代码
{
    class Program
    {
        static void Main(string[] args)
        {
            //计算两个数的最大公约数
            int a, b, i, result, temp;
            result = 0;
            Console.WriteLine("请输入第1个正整数:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第2个正整数:");
            b = Convert.ToInt32(Console.ReadLine());


            /*
            //找出一个数的所有素数
            int n, i;
            Console.WriteLine("请输入一个正整数:");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                for (i = 2; i <= n / 2; i++)
                    if (n % i == 0)
                        Console.WriteLine(i);
            }
            else
            {
                for (i = 3; i <= (n - 1) / 2; i++)
                    if (n % i == 0)
                        Console.WriteLine(i);
            }
            Console.ReadLine();
            */

            /*
            //奇、偶数求和
            int n, i, result;
            result = 0;
            Console.WriteLine("请输入一个正整数：");
            n = Convert.ToInt32(Console.ReadLine());//由控制台读入文本，并转换为整数赋值给n
            if (n % 2 == 0)
                for (i = 2; i <= n; i += 2)
                    result += i;
            else
                for (i = 1; i <= n; i += 2)
                    result += i;
            Console.WriteLine(result);
            */
           
        }
    }
}
