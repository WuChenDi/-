using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18位身份证判断性别_17位奇数为男_偶数为女
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string s_ident;
            char ch = ' ';
            Console.WriteLine("请输入18位身份证号码");
            s_ident = Console.ReadLine();
            if (s_ident.Length != 18)
            {
                Console.WriteLine("号码格式不正确");
                return;
            }
            for (i = 0; i < 17; i++)
            {
                ch =s_ident[17];
                if ((ch < '0' || ch > '9')&&ch !='X')
                {
                    Console.WriteLine("号码格式不正确");
                    return;
                }
            }
            ch = s_ident[17];
            if (ch < '0' || ch > '9')
            {
                Console.WriteLine("号码格式不正确");
                return;
            }
            if (s_ident[16] % 2 == 0)
                Console.WriteLine("性别为女");
            else
                Console.WriteLine("性别为男");
        }
    }
}
