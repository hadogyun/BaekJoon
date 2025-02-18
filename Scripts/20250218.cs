using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //소수 구하기
    public class _1929번
    {
        //에라토스테네스의 체
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();

            int m = int.Parse(strArray[0]);
            int n = int.Parse(strArray[1]);

            bool[] isPrime = Enumerable.Repeat(true, n + 1).ToArray();
            isPrime[0] = isPrime[1] = false;

            for (int i = 2; i * i <= n; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= n; j += i)
                        isPrime[j] = false;
                }
            }

            StringBuilder sb = new StringBuilder();

            for (int i = m; i <= n; i++)
            {
                if (isPrime[i])
                    sb.AppendLine(i.ToString());
            }

            Console.Write(sb.ToString());
        }
    }
}
