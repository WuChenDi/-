using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 采用除二其余法_将十进制正整数转换为二进制字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, i;
            string s_binary = "", s_temp = "";
            Console.WriteLine("请输入一个十进制正整数:");
            number = Convert .ToInt32 (Console.ReadLine());
            while (number != 0)
            {
                s_temp += number % 2;
                number /= 2;
            }
            for (i = s_temp.Length - 1; i >= 0; i--)
                s_binary += s_temp[i];
            Console.WriteLine("二进制字符串为:");
            Console.WriteLine(s_binary);

        }
    }
}
