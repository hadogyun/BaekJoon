using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //분해합
    public class _2231번
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i < n; i++)
            {
                if(DecompositionSum(i) == n)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine(0);
        }

        static int DecompositionSum(int num)
        {
            int sum = num;

            while(true)
            {
                if (num == 0)
                    break;

                sum += num % 10;
                num /= 10;
            }

            return sum;
        }
    }

    //수학은 비대면강의입니다
    public class _19532번
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();

            int a = int.Parse(strArray[0]);
            int b = int.Parse(strArray[1]);
            int c = int.Parse(strArray[2]);
            int d = int.Parse(strArray[3]);
            int e = int.Parse(strArray[4]);
            int f = int.Parse(strArray[5]);

            for(int i = -999; i <= 999; i++)
            {
                for(int j = -999; j <= 999; j++)
                {
                    if(a * i + b * j == c && d * i + e * j == f)
                    {
                        Console.WriteLine($"{i} {j}");
                        return;
                    }
                }
            }
        }
    }
}
