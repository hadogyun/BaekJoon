using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //직사각형
    public class _27323번
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a * b);
        }
    }

    //직사각형에서 탈출
    public class _1085번
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();

            int x = int.Parse(strArray[0]);
            int y = int.Parse(strArray[1]);
            int w = int.Parse(strArray[2]);
            int h = int.Parse(strArray[3]);

            int wLength = w - x > x ? x : w - x;
            int hLength = h - y > y ? y : h - y;

            if (wLength > hLength)
                Console.WriteLine(hLength);
            else
                Console.WriteLine(wLength);
        }
    }

    //네 번째 점
    public class _3009번
    {
        static void Main()
        {
            int[] xArray = new int[3];
            int[] yArray = new int[3];

            for(int i = 0; i < 3; i++)
            {
                string[] strArray = Console.ReadLine().Split();

                xArray[i] = int.Parse(strArray[0]);
                yArray[i] = int.Parse(strArray[1]);
            }

            int resultX;
            int resultY;

            if (xArray[0] == xArray[1])
                resultX = xArray[2];
            else if (xArray[0] == xArray[2])
                resultX = xArray[1];
            else
                resultX = xArray[0];

            if(yArray[0] == yArray[1])
                resultY = yArray[2];
            else if(yArray[0] == yArray[2])
                resultY = yArray[1];
            else
                resultY = yArray[0];

            Console.WriteLine($"{resultX} {resultY}");
        }
    }

    //수학은 체육과목 입니다
    public class _15894번
    {
        static void Main()
        {
            //n의 범위 주의(1 ≤ n ≤ 10^9)
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(4 * n);
        }
    }
}
