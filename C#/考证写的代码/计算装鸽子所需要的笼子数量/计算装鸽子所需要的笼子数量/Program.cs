using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算装鸽子所需要的笼子数量
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount, count = 0;
            Console.WriteLine("请输入鸽子总数:");
            amount = Convert.ToInt32(Console.ReadLine());
            while (amount > 0)
            {
                if (amount >= 5)
                    amount -= 5;
                else if (amount >= 2)
                    amount -= 2;
                else
                    amount--;
                count++;
            }
            Console.WriteLine("需要的笼子数为:");
            Console.WriteLine(count);
        }
    }
}
