using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //중앙 이동 알고리즘
    public class _2903번
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            // 1 => 9, 2 => 25, 5 => 1089
            Console.WriteLine((2 * Math.Pow(2, num - 1) + 1) * (2 * Math.Pow(2, num - 1) + 1));
        }
    }
}
