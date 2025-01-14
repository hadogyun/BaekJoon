using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //단어의 개수
    public class _1152번
    {
        //string.Trim - 전후 공백 삭제, StringSplitOptions 사용
        static void Main()
        {
            string[] stringArray = Console.ReadLine().Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(stringArray.Length);
        }
    }

    //상수
    public class _2908번
    {
        //string.Reverse 사용
        static void Main()
        {
            string[] stringArray = Console.ReadLine().Split();

            int a = int.Parse(stringArray[0].Reverse().ToArray());
            int b = int.Parse(stringArray[1].Reverse().ToArray());

            int result = 0;

            if (a > b)
                result = a;
            else
                result = b;

            Console.WriteLine(result);
        }
    }

    //다이얼
    public class _5622번
    {
        static void Main()
        {
            string str = Console.ReadLine();

            Console.WriteLine(CalculateTime(str));
        }

        static int CalculateTime(string s)
        {
            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case <= 'C':
                        sum += 3;
                        break;
                    case <= 'F':
                        sum += 4;
                        break;
                    case <= 'I':
                        sum += 5;
                        break;
                    case <= 'L':
                        sum += 6;
                        break;
                    case <= 'O':
                        sum += 7;
                        break;
                    case <= 'S':
                        sum += 8;
                        break;
                    case <= 'V':
                        sum += 9;
                        break;
                    case <= 'Z':
                        sum += 10;
                        break;
                }
            }

            return sum;
        }
    }

    //그대로 출력하기
    public class _11718번
    {
        //string.IsNullOrEmpty 사용
        static void Main()
        {
            while (true)
            {
                string str = Console.ReadLine();
                Console.WriteLine(str);

                if (string.IsNullOrEmpty(str))
                    return;
            }
        }
    }

    //새싹
    public class _25083번
    {
        static void Main()
        {
            Console.WriteLine("         ,r'\"7");
            Console.WriteLine("r`-_   ,'  ,/");
            Console.WriteLine(" \\. \". L_r'");
            Console.WriteLine("   `~\\/");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
        }
    }

    //킹, 퀸, 룩, 비숍, 나이트, 폰
    public class _3003번
    {
        static void Main()
        {
            int[] chessPieces = { 1, 1, 2, 2, 2, 8 };

            string[] stringArray = Console.ReadLine().Split();

            int[] intArray = new int[stringArray.Length];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(stringArray[i]);
                Console.Write(chessPieces[i] - intArray[i] + " ");
            }
        }
    }

    //별 찍기 - 7
    public class _2444번
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < (i - 1) * 2 + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < (i - 1) * 2 + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
