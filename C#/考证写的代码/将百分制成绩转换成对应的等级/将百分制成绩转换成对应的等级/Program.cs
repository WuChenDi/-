using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 将百分制成绩转换成对应的等级
{
    class Program
    {
        static void Main(string[] args)
        {
            int credit, level;
            Console.WriteLine("请输入百分制分数");
            credit = Convert.ToInt32(Console.ReadLine());
            if (credit > 100)
            {
                Console.WriteLine("分数应在0~100之间");
                return;
            }
            level = credit / 10;
            switch (level)
            {
                case 10:
                case 9:Console.WriteLine("优秀");break;
                case 8:Console.WriteLine("良好");break;
                case 7:Console.WriteLine("一般");break;
                case 6:Console.WriteLine("及格");break;
                case 5:
                case 4:
                case 3:
                case 2:
                case 1:
                    Console.WriteLine("不及格");break;
                default:Console.WriteLine("出错"); break;
            }
        }
    }
}
