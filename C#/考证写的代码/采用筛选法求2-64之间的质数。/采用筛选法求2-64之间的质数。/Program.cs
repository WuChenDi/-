using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 采用筛选法求2_64之间的质数_
{
   public  class Program
    {
        public  void Main(string[] args)
        {
            int sieve, w;
            int i, j, p, k;
            bool flg = true;
            sieve = _0x0;
            p = 3;
            for (i = 0; i < 32; i++)
            {
                w = 0x1 << i; w <<= p; j = p;
                while (j + i < 32)
                {
                    sieve &= ~w;
                    w <<= p; j += p;
                }
                k = i + 1;
                while (((sieve >> k) & 0x01) == 0)
                {
                    k++; i++;
                }
                p = p + 2;
            }
            Console.WriteLine("2到64之间的素数有");
            Console.Write("{0,4}", 2);
            p = 3; w = 1;
            for (i = 0; i < 32; i++)
            {
                if ((sieve >> i & 0x01) != 0)
                    Console.Write("{0,3}", p);
                p += 2;
            }
            Console.WriteLine();
            Console.Read();
        }
}
