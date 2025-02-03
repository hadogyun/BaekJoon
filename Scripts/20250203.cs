using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //알고리즘 수업 - 알고리즘의 수행 시간 6
    public class _24267번
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(n * (n - 1) * (n - 2) / 6);
            Console.WriteLine(3);
        }
    }

    //알고리즘 수업 - 점근적 표기 1
    public class _24313번
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();

            int a1 = int.Parse(strArray[0]);
            int a0 = int.Parse(strArray[1]);

            int c = int.Parse(Console.ReadLine());
            int n0 = int.Parse(Console.ReadLine());

            if (a1 <= c && a1 * n0 + a0 <= c * n0)
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }
    }

    //블랙잭
    public class _2798번
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();

            int count = int.Parse(strArray[0]);
            int limitNum = int.Parse(strArray[1]);

            string[] numArray = Console.ReadLine().Split();

            List<int> intList = numArray.Select(int.Parse).ToList();

            int result = 0;

            for(int i = 0; i < count; i++)
            {
                for(int j = i + 1; j < count; j++)
                {
                    for(int k = j + 1; k < count; k++)
                    {
                        int sum = intList[i] + intList[j] + intList[k];
                        
                        if(sum <= limitNum && sum > result)
                            result = sum;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
