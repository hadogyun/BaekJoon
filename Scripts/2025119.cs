using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //벌집
    public class _2292번
    {
        static void Main()
        {
            int roomNum = int.Parse(Console.ReadLine());

            //1, 6, 12, 18, 24 => 총 방의 갯수가 6개씩 늘어남

            int result = 1;      //이동 칸수
            int tempNum = 1;     //임시 방 총 갯수

            while (true)
            {
                if(roomNum > tempNum)
                {
                    tempNum += result * 6;
                    result++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }

    //분수찾기
    public class _1193번
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            //1, 2, 3, 4 ...로 증가
            //2, 3, 4, 5 ...로 분수 + 분모 값 증가

            int lineCount = 0;
            int lineSum = 0;
            int lineIndex = 0;

            while(count > lineSum)
            {
                lineCount++;
                lineSum += lineCount;
            }

            lineIndex = count - (lineSum - lineCount);

            if (lineCount % 2 == 1)
                Console.WriteLine($"{lineCount - lineIndex + 1}/{lineIndex}");
            else
                Console.WriteLine($"{lineIndex}/{lineCount - lineIndex + 1}");
        }
    }
}
