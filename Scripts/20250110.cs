using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon
{
    public class _11382번
    {
        //첫 번째 줄에 A, B, C (1 ≤ A, B, C ≤ 1012)이 공백을 사이에 두고 주어진다.
        //int와 long의 차이
        static void Main()
        {
            string[] stringArray = Console.ReadLine().Split();

            long a = long.Parse(stringArray[0]);
            long b = long.Parse(stringArray[1]);
            long c = long.Parse(stringArray[2]);

            Console.WriteLine(a + b + c);
        }
    }

    public class _10171번
    {
        // \를 출력하기 위해서는 두번 입력해야함
        // cf. \n : 문자열에서 줄바꿈
        // cf. \t : 문자열에서 탭
        static void Main()
        {
            Console.WriteLine("\\    /\\");
            Console.WriteLine(" )  ( ')");
            Console.WriteLine("(  /  )");
            Console.WriteLine(" \\(__)|");
        }
    }

    public class _10172번
    {
        // "를 출력하기 위해서 \를 앞에 붙여줘야함
        static void Main()
        {
            Console.WriteLine("|\\_/|");
            Console.WriteLine("|q p|   /}");
            Console.WriteLine("( 0 )\"\"\"\\");
            Console.WriteLine("|\"^\"`    |");
            Console.WriteLine("||_/=\\\\__|");
        }
    }

    public class _1330번
    {
        static void Main()
        {
            string[] stringArray = Console.ReadLine().Split();

            int a = int.Parse(stringArray[0]);
            int b = int.Parse(stringArray[1]);

            if (a > b)
            {
                Console.WriteLine(">");
            }
            else if (a < b)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("==");
            }

            //switch문으로 작성
            switch (a > b)
            {
                case true:
                    Console.WriteLine(">");
                    break;
                case false when (a < b):
                    Console.WriteLine("<");
                    break;

                default:
                    Console.WriteLine("==");
                    break;
            }
        }
    }

    public class _9498번
    {
        static void Main()
        {
            int score = int.Parse(Console.ReadLine());

            if (score >= 90)
            {
                Console.WriteLine("A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }

    public class _2753번
    {
        // 윤년 판별
        static void Main()
        {
            int year = int.Parse(Console.ReadLine());

            if (year < 1 || year > 4000)
            {
                return;
            }

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }

    public class _14681번
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("4");
            }
        }
    }

    public class _2884번
    {
        //알람시계
        static void Main()
        {
            string[] stringArray = Console.ReadLine().Split();

            int hour = int.Parse(stringArray[0]);
            int minute = int.Parse(stringArray[1]);

            minute -= 45;

            if (minute < 0)
            {
                minute += 60;
                hour -= 1;

                if (hour < 0)
                {
                    hour = 23;
                }
            }

            Console.WriteLine($"{hour} {minute}");
        }
    }

    public class _2525번
    {
        //오븐시계
        static void Main()
        {
            string[] stringArray = Console.ReadLine().Split();

            int hour = int.Parse((stringArray[0]));
            int minute = int.Parse((stringArray[1]));

            int requireTime = int.Parse(Console.ReadLine());

            minute += requireTime;

            while (minute >= 60)
            {
                hour++;
                minute -= 60;
            }

            if (hour >= 24)
            {
                hour -= 24;
            }

            Console.WriteLine($"{hour} {minute}");
        }
    }

    public class _2480번
    {
        //주사위 세개
        static void Main()
        {
            string[] stringArray = Console.ReadLine().Split();

            int a = int.Parse((stringArray[0]));
            int b = int.Parse((stringArray[1]));
            int c = int.Parse((stringArray[2]));

            if (a == b && b == c)
            {
                Console.WriteLine($"{10000 + a * 1000}");
            }
            else if (a == b)
            {
                Console.WriteLine($"{1000 + a * 100}");
            }
            else if (a == c)
            {
                Console.WriteLine($"{1000 + a * 100}");
            }
            else if (b == c)
            {
                Console.WriteLine($"{1000 + b * 100}");
            }
            else
            {
                if(a > b && a > c)
                {
                    Console.WriteLine($"{100 * a}");
                }
                else if(b > c)
                {
                    Console.WriteLine($"{100 * b}");
                }
                else
                {
                    Console.WriteLine($"{100 * c}");
                }
            }    
        }
    }
}
