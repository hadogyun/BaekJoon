using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //대지
    public class _9063번
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            List<int> xList = new List<int>();
            List<int> yList = new List<int>();

            for (int i = 0; i < count; i++)
            {
                string[] strArray = Console.ReadLine().Split();

                int tempX = int.Parse(strArray[0]);
                int tempY = int.Parse(strArray[1]);

                xList.Add(tempX);
                yList.Add(tempY);
            }

            int width = xList.Max() - xList.Min();
            int height = yList.Max() - yList.Min();

            Console.WriteLine(width * height);
        }
    }

    //삼각형 외우기
    public class _10101번
    {
        static void Main()
        {
            List<int> angleList = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                int angle = int.Parse(Console.ReadLine());

                angleList.Add(angle);
            }

            if (angleList.Sum() != 180)
            {
                Console.WriteLine("Error");
            }
            else
            {
                if (angleList[0] == 60 && angleList[1] == 60 && angleList[2] == 60)
                {
                    Console.WriteLine("Equilateral");
                }
                else if (angleList[0] == angleList[1] || angleList[1] == angleList[2] || angleList[2] == angleList[0])
                {
                    Console.WriteLine("Isosceles");
                }
                else if (angleList[0] != angleList[1] && angleList[1] != angleList[2])
                {
                    Console.WriteLine("Scalene");
                }
            }
        }
    }

    //삼각형과 세 변
    public class _5073번
    {
        static void Main()
        {
            while (true)
            {
                string[] strArray = Console.ReadLine().Split();

                int a = int.Parse(strArray[0]);
                int b = int.Parse(strArray[1]);
                int c = int.Parse(strArray[2]);

                if (a == 0)
                    break;

                List<int> intList = new List<int>();

                intList.Add(a);
                intList.Add(b);
                intList.Add(c);

                if (intList.Max() >= intList.Sum() - intList.Max())
                {
                    Console.WriteLine("Invalid");
                }
                else if (a == b && b == c)
                {
                    Console.WriteLine("Equilateral");
                }
                else if (a == b || b == c || c == a)
                {
                    Console.WriteLine("Isosceles");
                }
                else if (a != b && b != c)
                {
                    Console.WriteLine("Scalene");
                }
            }
        }
    }

    //세 막대
    public class _14215번
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();

            int a = int.Parse(strArray[0]);
            int b = int.Parse(strArray[1]);
            int c = int.Parse(strArray[2]);

            List<int> intList = new List<int>();

            intList.Add(a);
            intList.Add(b);
            intList.Add(c);

            int result = 0;

            if (intList.Max() >= intList.Sum() - intList.Max())
            {
                result = (intList.Sum() - intList.Max()) + (intList.Sum() - intList.Max() - 1);
            }
            else
            {
                result = intList.Sum();
            }

            Console.WriteLine(result);
        }
    }
}
