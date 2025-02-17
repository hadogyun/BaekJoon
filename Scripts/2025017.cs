using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //다음 소수
    public class _4134번
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            for(long i = 0; i < count; i++)
            {
                long num = long.Parse(Console.ReadLine());

                for(long j = num; ; j++)
                {
                    if (j <= 1)
                        continue;

                    if(j <= 3)
                    {
                        Console.WriteLine(j);
                        break;
                    }

                    if (j % 2 == 0 || j % 3 == 0)
                        continue;

                    bool isPrime = true;

                    for(long k = 5; k * k <= j; k+=6)
                    {
                        if(j % k == 0 || j % (k + 2) == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if(isPrime)
                    {
                        Console.WriteLine(j);
                        break;
                    }
                }
            }
        }
    }
}
