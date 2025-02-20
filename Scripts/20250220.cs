using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //골드바흐 파티션
    public class _17103번
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            bool[] isPrime = Enumerable.Repeat(true, 1000000 + 1).ToArray();

            for(int i = 2; i * i <= 1000000; i++)
            {
                if(isPrime[i])
                {
                    for(int j = i * i; j <= 1000000; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            for(int i = 0; i < num; i++)
            {
                int count = 0;
                int n = int.Parse(Console.ReadLine());

                for(int j = 2; j <= n/2; j++)
                {
                    if (isPrime[j] && isPrime[n - j])
                        count++;
                }

                Console.WriteLine(count);
            }
        }
    }
}
