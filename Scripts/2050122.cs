using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //소수 찾기
    public class _1978번
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            string[] strArray = Console.ReadLine().Split();

            int result = num;

            for(int i = 0; i < num; i++)
            {
                int temp = int.Parse(strArray[i]);

                if (temp == 1)
                {
                    result--;
                    continue;
                }

                for(int j = 2; j < temp; j++)
                {
                    if(temp % j == 0)
                    {
                        result--;
                        break;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }

    //소수
    public class _2581번
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            //소수를 담을 리스트
            List<int> intList = new List<int>();

            for(int i = a; i <= b; i++)
            {
                if (i == 1)
                    continue;

                for(int j = 2; j <= i; j++)
                {
                    if (i % j == 0 && j != i)
                    {
                        break;
                    }
                    else if(i % j == 0 && j == i)
                    {
                        intList.Add(j);
                    }
                }
            }

            if(intList.Count > 0)
            {
                int sumResult = intList.Sum();
                int minResult = intList.Min();

                Console.WriteLine(sumResult);
                Console.WriteLine(minResult);
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }

    //소인수분해
    public class _11653번
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for(int i = 2; i <= num; i++)
            {
                while(num % i == 0)
                {
                    Console.WriteLine(i);
                    num /= i;
                }
            }
        }
    }
}
