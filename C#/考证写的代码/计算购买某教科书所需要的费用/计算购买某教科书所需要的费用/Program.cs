using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算购买某教科书所需要的费用
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount, cost, level,i;
            level = 25;
            Console.WriteLine("请输入购买教科书的数量:");
            amount = Convert.ToInt32(Console.ReadLine());
            cost = level * amount;
            level = Convert.ToInt32(Math.Log10(amount));
            switch (level )
            {
                case 1:cost = Convert.ToInt32(cost * 0.9);break;
                case 2:cost = Convert.ToInt32(cost * 0.85);break;
                case 3:cost = Convert.ToInt32(cost * 0.8);break;
            }
            Console.WriteLine("所需要费用为");
            Console.WriteLine(cost);
        }
    }
}
