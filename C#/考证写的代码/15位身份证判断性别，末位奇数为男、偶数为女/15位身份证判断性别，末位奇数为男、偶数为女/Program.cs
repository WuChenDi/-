using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15位身份证判断性别_末位奇数为男_偶数为女
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string s_ident;
            char ch = ' ';
            Console.WriteLine("请输入15位身份证号码");
            s_ident = Console.ReadLine();
            if (s_ident.Length != 15)
            {
                Console.WriteLine("号码格式不正确");
                return;
            }
            for (i = 0; i < 15; i++)
            {
                ch = s_ident[i];
                if (ch < '0' || ch > '9')
                {
                    Console.WriteLine("号码格式不正确");
                    return;
                }
            }
            if (ch % 2 == 0)
                Console.WriteLine("性别为女");
            else
                Console.WriteLine("性别为男");
        }
    }
}
