using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //수 정렬하기
    public class _2750번
    {
        static void Main()
        {
            List<int> intList = new List<int>();

            int count = int.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                int n = int.Parse((Console.ReadLine()));

                intList.Add(n);
            }

            intList.Sort();

            for(int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);
            }
        }
    }

    //대표값2
    public class _2587번
    {
        static void Main()
        {
            List<int> intList = new List<int>();

            int count = 5;

            for (int i = 0; i < count; i++)
            {
                int n = int.Parse((Console.ReadLine()));

                intList.Add(n);
            }

            intList.Sort();

            Console.WriteLine(intList.Average());
            Console.WriteLine(intList[2]);
        }
    }

    //커트라인
    public class _25305번
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();

            int n = int.Parse(strArray[0]);     //응시자 수
            int k = int.Parse(strArray[1]);     //상을 받는 사람의 수

            string[] strArray2 = Console.ReadLine().Split();

            List<int> scoreList = new List<int>();

            for(int i = 0; i < n; i++)
            {
                scoreList.Add(int.Parse(strArray2[i]));
            }

            scoreList.Sort();
            scoreList.Reverse();

            Console.WriteLine(scoreList[k - 1]);
        }
    }

    //수 정렬하기 2
    public class _2751번
    {
        static void Main()
        {
            List<int> intList = new List<int>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int n = int.Parse((Console.ReadLine()));

                intList.Add(n);
            }

            intList.Sort();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < intList.Count; i++)
            {
                sb.Append(intList[i] + "\n");
            }

            Console.WriteLine(sb.ToString());
        }
    }

    //수 정렬하기 3
    public class _10989번
    {
        //StreamReader, StreamWriter 사용
        static void Main()
        {
            StreamReader reader = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter writer = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(reader.ReadLine());
            int[] intArray = new int[10001];
            
            for(int i = 0; i < n; i++)
            {
                int num = int.Parse(reader.ReadLine());
                intArray[num]++;
            }

            for(int i = 0; i <= 10000; i++)
            {
                while(intArray[i] > 0)
                {
                    writer.WriteLine(i);
                    intArray[i]--;
                }
            }

            reader.Close();
            writer.Close();
        }
    }
}
