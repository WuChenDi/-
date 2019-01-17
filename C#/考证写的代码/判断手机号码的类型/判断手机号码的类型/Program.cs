using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判断手机号码的类型
{
    class Program
    {
        static void Main(string[] args)
        {
            string s_phone;
            Console.WriteLine("请输入手机号码:");
            s_phone = Console.ReadLine();
            if ((s_phone.Length != 11) || s_phone[0] != '1' || s_phone[1] != '3')
            {
                Console.WriteLine("无效手机号码");
                return;
            }
            if (s_phone[2] == '0' || s_phone[2] == '1')
                Console.WriteLine("联通GSM用户");
            else if (s_phone[2] == '3')
                Console.WriteLine("联通CDMA用户");
            else if (s_phone[2] == '2' || s_phone[2] == '4')
                Console.WriteLine("无效手机号码");
            else if (s_phone[2] == '5' || s_phone[2] == '9')
                Console.WriteLine("移动用户");

        }
    }
}
