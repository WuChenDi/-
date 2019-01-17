using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判断一个正整数是否是平方数
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            bool square = false ;
            Console.WriteLine("请输入一位正整数:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= n / 2; i++)
                if (n==i*i)
                {
                    square = true ;
                    break;
                }
            if (square  == true)
                Console.WriteLine("该数为平方数,平方根为"+i);
            else
                Console.WriteLine("该数位非平方数:");
        }
    }
}
