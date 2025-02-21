using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //창문 닫기
    public class _13909번
    {
        static void Main()
        {
            ulong N = ulong.Parse(Console.ReadLine());
            int openCount = 0;

            for (ulong i = 1; i <= Math.Sqrt(N); i++)
                openCount++;

            Console.WriteLine(openCount);
        }
    }
}
