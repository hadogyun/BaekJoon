using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //구구단
    public class _2739번
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"{num} * {i + 1} = {num * (i + 1)}");
            }
        }
    }

    //A + B - 3
    public class _10950번
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] stringArray = Console.ReadLine().Split();

                int a = int.Parse(stringArray[0]);
                int b = int.Parse(stringArray[1]);

                Console.WriteLine(a + b);
            }
        }
    }

    //합
    public class _8393번
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = 0; i < num; i++)
            {
                result += i + 1;
            }

            Console.WriteLine(result);
        }
    }

    //영수증
    public class _25304번
    {
        static void Main()
        {
            //총금액
            int total = int.Parse(Console.ReadLine());

            //물건 종류 수
            int num = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = 0; i < num; i++)
            {
                string[] stringArray = Console.ReadLine().Split();

                int price = int.Parse(stringArray[0]);
                int count = int.Parse(stringArray[1]);

                result += price * count;
            }

            if (total == result)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }

    //코딩은 체육과목입니다
    public class _25314번
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine()) / 4;

            string result = string.Empty;

            for (int i = 0; i < count; i++)
            {
                result += "long ";
            }

            result += "int";

            Console.WriteLine(result);
        }
    }

    //빠른 A + B
    public class _15552번
    {
        //stringBuilder의 사용
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] num = Console.ReadLine().Split();
                sb.Append(int.Parse(num[0]) + int.Parse(num[1]) + "\n");
            }

            Console.WriteLine(sb.ToString());
        }
    }

    //A + B - 7
    public class _11021번
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                string[] stringArray = Console.ReadLine().Split();

                int a = int.Parse(stringArray[0]);
                int b = int.Parse(stringArray[1]);

                sb.Append($"Case #{i + 1}: {a + b}" + "\n");
            }

            Console.WriteLine(sb.ToString());
        }
    }

    //A + B - 8
    public class _11022번
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                string[] stringArray = Console.ReadLine().Split();

                int a = int.Parse(stringArray[0]);
                int b = int.Parse(stringArray[1]);

                sb.Append($"Case #{i + 1}: {a} + {b} = {a + b}" + "\n");
            }

            Console.WriteLine(sb.ToString());
        }
    }

    //별 찍기 - 1
    public class _2438번
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            string result = string.Empty;

            for (int i = 0; i < count; i++)
            {
                result += "*";

                Console.WriteLine(result);
            }
        }
    }

    //별 찍기 - 2
    public class _2439번
    {
        //2중 for문...
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string result = string.Empty;

                for (int j = 0; j < count - i - 1; j++)
                {
                    result += " ";
                }

                for (int j = 0; j < i + 1; j++)
                {
                    result += "*";
                }

                Console.WriteLine(result);
            }
        }
    }
}
