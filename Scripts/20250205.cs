using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //체스판 다시 칠하기
    public class _1018번
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();

            int n = int.Parse(strArray[0]);
            int m = int.Parse(strArray[1]);

            string[] board = new string[n];

            for(int i = 0; i < n; i++)
            {
                board[i] = Console.ReadLine();
            }

            int res = 64;
            for (int i = 0; i <= n - 8; i++)
            {
                for (int j = 0; j <= m - 8; j++)
                {
                    int case1 = 0;
                    int case2 = 0;

                    for (int k = i; k < i + 8; k++)
                    {
                        for (int l = j; l < j + 8; l++)
                        {
                            if ((k + l) % 2 == 0)
                            {
                                if (board[k][l] != 'W') case1++;
                                if (board[k][l] != 'B') case2++;
                            }
                            else
                            {
                                if (board[k][l] != 'B') case1++;
                                if (board[k][l] != 'W') case2++;
                            }
                        }
                    }
                    res = Math.Min(res, Math.Min(case1, case2));
                }
            }

            Console.WriteLine(res);
        }
    }

    //영화감독 숌
    public class _1436번
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int num = 666;

            int count = 1;

            while(n != count)
            {
                num++;

                if(Convert.ToString(num).Contains("666"))
                {
                    count++;
                }
            }

            Console.WriteLine(num);
        }
    }

    //설탕 배달
    public class _2839번
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int count = n / 5;

            while(count >= 0)
            {
                int result = n - count * 5;

                if(result % 3 == 0)
                {
                    count += result / 3;
                    Console.WriteLine(count);
                    return;
                }
                else
                {
                    count--;
                }
            }

            Console.WriteLine("-1");
        }
    }
}
