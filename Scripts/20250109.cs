using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon
{
    public class _2557번
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class _1000번
    {
        static void Main()
        {
            string[] s = Console.ReadLine().Split();

            Console.WriteLine(int.Parse(s[0]) + int.Parse(s[1]));
        }
    }

    public class _1001번
    {
        static void Main()
        {
            string[] s = Console.ReadLine().Split();

            Console.WriteLine(int.Parse(s[0]) - int.Parse(s[1]));
        }
    }

    public class _10998번
    {
        static void Main()
        {
            string[] s = Console.ReadLine().Split();

            Console.WriteLine(int.Parse(s[0]) * int.Parse(s[1]));
        }
    }

    public class _1008번
    {
        static void Main()
        {
            string[] s = Console.ReadLine().Split();

            Console.WriteLine(double.Parse(s[0]) / double.Parse(s[1]));
        }
    }
    
    public class _10869번
    {
        static void Main()
        {
            string[] s = Console.ReadLine().Split();

            Console.WriteLine(int.Parse(s[0]) + int.Parse(s[1]));
            Console.WriteLine(int.Parse(s[0]) - int.Parse(s[1]));
            Console.WriteLine(int.Parse(s[0]) * int.Parse(s[1]));
            Console.WriteLine(int.Parse(s[0]) / int.Parse(s[1]));
            Console.WriteLine(int.Parse(s[0]) % int.Parse(s[1]));
        }
    }

    public class _10926번
    {
        static void Main()
        {
            string id = Console.ReadLine();

            Console.WriteLine(id + "??!");
        }
    }

    public class _18108번
    {
        static void Main()
        {
            int budaYear = int.Parse(Console.ReadLine());

            Console.WriteLine(budaYear - 543);
        }
    }

    public class _10430번
    {
        static void Main()
        {
            string[] stringArray = Console.ReadLine().Split();

            int a = int.Parse(stringArray[0]);
            int b = int.Parse(stringArray[1]);
            int c = int.Parse(stringArray[2]);

            Console.WriteLine((a + b) % c);
            Console.WriteLine(((a % c) + (b % c)) % c);
            Console.WriteLine((a * b) % c);
            Console.WriteLine((a % c) * (b % c) % c);
        }
    }

    public class _2588번
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());

            string b = Console.ReadLine();
            int b0 = int.Parse(b);

            char[] charArray = b.ToCharArray();
            int b1 = int.Parse(charArray[0].ToString());
            int b2 = int.Parse(charArray[1].ToString());
            int b3 = int.Parse(charArray[2].ToString());

            Console.WriteLine(b3 * a);
            Console.WriteLine(b2 * a);
            Console.WriteLine(b1 * a);
            Console.WriteLine(b0 * a);
        }
    }
}
