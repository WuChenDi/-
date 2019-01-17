using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算多个数的平均数
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            float total = 0;
            string s_input;
            Console.WriteLine("请依次输入样本值，输入X退出:");
            s_input = Console.ReadLine();
            while (!(Convert.ToChar(s_input) == 'x' || Convert.ToChar(s_input) == 'X'))
            {
                count++;
                total += int.Parse(s_input);
                s_input = Console.ReadLine();

            }
            total /= count;
            Console.WriteLine("平均值为:");
            Console.WriteLine(total);
        
        }
    }
}
