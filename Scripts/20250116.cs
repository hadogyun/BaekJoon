using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //행렬 덧셈
    public class _2738번
    {
        static void Main()
        {
            string[] stringArray = Console.ReadLine().Split();
            int n = int.Parse(stringArray[0]);
            int m = int.Parse(stringArray[1]);

            int[,] A = new int[n, m];
            int[,] B = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();

                for (int j = 0; j < m; j++)
                {
                    A[i, j] = int.Parse(line[j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();

                for (int j = 0; j < m; j++)
                {
                    B[i, j] = int.Parse(line[j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(A[i, j] + B[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    //최댓값
    public class _2566번
    {
        static void Main()
        {
            int x = 0;
            int y = 0;
            int maxValue = 0;

            for (int i = 0; i < 9; i++)
            {
                List<int> intList = new List<int>();

                string[] strArray = Console.ReadLine().Split();

                for (int j = 0; j < strArray.Length; j++)
                {
                    intList.Add(int.Parse(strArray[j]));
                }

                if (intList.Max() > maxValue)
                {
                    x = i;
                    y = intList.FindIndex(_ => _ == intList.Max());
                    maxValue = intList.Max();
                }
            }

            Console.WriteLine(maxValue);
            Console.WriteLine($"{x + 1} {y + 1}");
        }
    }

    //세로읽기
    public class _10798번
    {
        static void Main()
        {
            char[,] box = new char[5, 15];

            string input = "";

            string result = "";

            for(int i = 0; i < 5; i++)
            {
                input = Console.ReadLine();

                for(int j = 0; j < input.Length; j++)
                {
                    box[i, j] = input[j];
                }
            }

            for(int i = 0; i < 15; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (box[j, i] == '\0')
                        continue;

                    result += box[j, i];
                }
            }

            Console.WriteLine(result);
        }
    }

    //색종이
    public class _2563번
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            string[] input;

            bool[,] whitePaper = new bool[100, 100];

            int result = 0;

            for(int i = 0; i < count; i++)
            {
                input = Console.ReadLine().Split();

                int x = int.Parse(input[0]);
                int y = int.Parse(input[1]);

                for(int j = x; j < x + 10; j++)
                {
                    for(int k = y; k < y + 10; k++)
                    {
                        whitePaper[j, k] = true;
                    }
                }
            }

            for(int i = 0; i < 100; i++)
            {
                for(int j = 0; j < 100; j++)
                {
                    if (whitePaper[i, j] == true)
                        result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}
