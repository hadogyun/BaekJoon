using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //배수와 약수
    public class _5086번
    {
        static void Main()
        {
            while (true)
            {
                string[] strArray = Console.ReadLine().Split();

                int a = int.Parse(strArray[0]);
                int b = int.Parse(strArray[1]);

                if (a == 0 && b == 0)
                    break;

                if (a > b)
                {
                    if (a % b == 0)
                    {
                        Console.WriteLine("multiple");
                    }
                    else
                    {
                        Console.WriteLine("neither");
                    }
                }
                else
                {
                    if (b % a == 0)
                    {
                        Console.WriteLine("factor");
                    }
                    else
                    {
                        Console.WriteLine("neither");
                    }
                }
            }
        }
    }

    //약수 구하기
    public class _2501번
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();

            int a = int.Parse(strArray[0]);
            int b = int.Parse(strArray[1]);

            List<int> factorList = new List<int>();

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    factorList.Add(i);
                }
            }

            if (factorList.Count >= b)
            {
                Console.WriteLine(factorList[b - 1]);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }

    //약수들의 합
    public class _9506번
    {
        static List<int> factorList = new List<int>();

        static void Main()
        {
            while (true)
            {
                string str = Console.ReadLine();

                if (str == "-1")
                    break;

                int num = int.Parse(str);

                factorList.Clear();
                int sum = 0;

                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        factorList.Add(i);
                        sum += i;
                    }
                }

                if (sum == num)
                {
                    Console.Write($"{num} = ");

                    for (int i = 0; i < factorList.Count; i++)
                    {
                        if (i == factorList.Count - 1)
                            Console.Write($"{factorList[i]}");
                        else
                            Console.Write($"{factorList[i]} + ");
                    }

                    Console.Write("\n");
                }
                else
                {
                    Console.WriteLine($"{num} is NOT perfect.");
                }
            }
        }
    }
}
