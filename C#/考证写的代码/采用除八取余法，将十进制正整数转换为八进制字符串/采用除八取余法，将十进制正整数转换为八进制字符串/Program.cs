using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 采用除八取余法_将十进制正整数转换为八进制字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, i;
            string s_octal = "", s_temp = "";
            Console.WriteLine("请输入一个十进制的正整数:");
            number = Convert.ToInt32(Console.ReadLine());
            while (number >= 7)
            {
                s_temp += number % 8;
                number /= 8;
            }
           // s_temp += number;
            for (i = s_temp.Length - 1; i >= 0; i--)
            {
                s_octal += s_temp[i];
            }  
            Console.WriteLine("八进制字符串为:");
            Console.WriteLine(s_octal);
        }
    }
}
