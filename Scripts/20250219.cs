using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //베르트랑 공준
    public class _4948번
    {
        static void Main()
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == 0)
                    break;

                int count = 0;

                for (int i = n + 1; i <= 2 * n; i++)
                {
                    if (IsPrime(i))
                        count++;
                }

                Console.WriteLine(count);
            }
        }

        static bool IsPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
