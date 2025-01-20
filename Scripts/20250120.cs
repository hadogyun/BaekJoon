using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //달팽이는 올라가고 싶다
    public class _2869번
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();

            int up = int.Parse(strArray[0]);
            int down = int.Parse(strArray[1]);
            int height = int.Parse(strArray[2]);

            //시간초과 코드
            //int currentHeight = 0;
            //int count = 0;

            //while (true)
            //{
            //    if (currentHeight < height)
            //    {
            //        currentHeight += up;
            //        count++;
            //    }

            //    if (currentHeight >= height)
            //    {
            //        break;
            //    }

            //    currentHeight -= down;
            //}

            //Console.WriteLine(count);

            int result = (height - down - 1) / (up - down) + 1;

            Console.WriteLine(result);
        }
    }
}
