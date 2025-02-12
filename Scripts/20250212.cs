using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //숫자 카드 2
    public class _10816번
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int count = int.Parse(Console.ReadLine());

            Dictionary<int, int> dic = new Dictionary<int, int>();

            string[] strArray = Console.ReadLine().Split();

            for(int i = 0; i < count; i++)
            {
                int temp = int.Parse(strArray[i]);

                if(dic.ContainsKey(temp))
                {
                    dic[temp]++;
                }
                else
                {
                    dic.Add(temp, 1);
                }
            }

            int m = int.Parse(Console.ReadLine());

            string[] strArray2 = Console.ReadLine().Split();

            List<int> intList = new List<int>();

            for(int i = 0; i < m; i++)
            {
                int temp = int.Parse(strArray2[i]);

                intList.Add(temp);
            }

            for(int i = 0; i < intList.Count; i++)
            {
                if(dic.ContainsKey(intList[i]))
                {
                    sb.Append(dic[intList[i]] + " ");
                }
                else
                {
                    sb.Append(0 + " ");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }

    //듣보잡
    public class _1764번
    {
        //List.Contains() 보다 Dictionary.ContainsKey() 를 하는것이 시간적에서 이득
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();

            int n = int.Parse(strArray[0]);
            int m = int.Parse(strArray[1]);

            Dictionary<string, int> dic = new Dictionary<string, int>();

            for(int i = 0; i < n; i++)
            {
                string temp = Console.ReadLine();

                dic.Add(temp, 1);
            }

            List<string> resultList = new List<string>();

            for(int i = 0; i < m ; i++)
            {
                string temp = Console.ReadLine();

                if(dic.ContainsKey(temp))
                {
                    resultList.Add(temp);
                }
            }

            resultList.Sort();

            Console.WriteLine(resultList.Count);

            for(int i = 0; i < resultList.Count; i++)
            {
                Console.WriteLine(resultList[i]);
            }
        }
    }

    //대칭 차집합
    public class _1269번
    {
        //Array.Except() 사용
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();

            int countA = int.Parse(strArray[0]);
            int countB = int.Parse(strArray[1]);

            strArray = Console.ReadLine().Split();
            int[] intArrayA = Array.ConvertAll(strArray, int.Parse);

            strArray = Console.ReadLine().Split();
            int[] intArrayB = Array.ConvertAll(strArray, int.Parse);
            
            var exceptA = intArrayA.Except(intArrayB);
            var exceptB = intArrayB.Except(intArrayA);

            Console.WriteLine(exceptA.Count() + exceptB.Count());
        }
    }

    //서로 다른 부분 문자열의 개수
    public class _11478번
    {
        //Substring(), Distinct() 사용
        static void Main()
        {
            string input = Console.ReadLine();
            int length = input.Length;
            int count = 0;

            for (int i = 1; i <= length; i++)
            {
                List<string> strList = new List<string>();

                for (int j = 0; j <= length - i; j++)
                {
                    strList.Add(input.Substring(j, i));
                }

                count += strList.Distinct().ToArray().Count();
            }

            Console.WriteLine(count);
        }
    }
}
