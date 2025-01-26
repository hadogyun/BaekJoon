using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //알고리즘 수업 - 알고리즘의 수행 시간 4
    public class _24265번
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(n * (n - 1) / 2);
            Console.WriteLine(2);
        }
    }
}
