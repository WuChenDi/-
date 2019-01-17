using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 找出一个字符串中ASCLL码最大的字符
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string s_text;
            char ch = ' ';
            Console.WriteLine("请输入一个字符串");
            s_text = Console.ReadLine();
            ch = s_text[0];
            for (i = 0; i < s_text.Length; i++)
            {
                if (ch < s_text[i])
                    ch = s_text[i];
            }
            Console.WriteLine("ASCLL码最大的字符位:");
            Console.WriteLine(ch);            
        }
    }
}
