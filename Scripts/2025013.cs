using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //최소공배수
    public class _1934번
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] strArray = Console.ReadLine().Split();

                int a = int.Parse(strArray[0]);
                int b = int.Parse(strArray[1]);

                Console.WriteLine(LCM(a, b));
            }
        }

        //최대공약수 : 유클리드 호제법
        static int GCD(int a, int b)
        {
            while(b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        //최소공배수
        static int LCM(int a, int b)
        {
            return (a / GCD(a, b)) * b;
        }
    }

    //최소공배수
    public class _13241번
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();

            long a = long.Parse(strArray[0]);
            long b = long.Parse(strArray[1]);

            Console.WriteLine(LCM(a, b));
        }

        //최대공약수 : 유클리드 호제법
        static long GCD(long a, long b)
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        //최소공배수
        static long LCM(long a, long b)
        {
            return (a / GCD(a, b)) * b;
        }
    }

    //분수 합
    public class _1735번
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();

            int a1 = int.Parse(strArray[0]);
            int b1 = int.Parse(strArray[1]);

            string[] strArray2 = Console.ReadLine().Split();

            int a2 = int.Parse(strArray2[0]);
            int b2 = int.Parse(strArray2[1]);

            int numerator = a1 * b2 + b1 * a2;
            int denominator = b1 * b2;

            int gcd = GCD(numerator, denominator);

            Console.WriteLine($"{numerator / gcd} {denominator / gcd}");
        }

        //최대공약수 : 유클리드 호제법
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}
