using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //나머지
    public class _3052번
    {
        //List 사용
        static void Main()
        {
            int lineCount = 10;
            int divNum = 42;

            List<int> numList = new List<int>();

            List<int> answerList = new List<int>();

            for (int i = 0; i < lineCount; i++)
            {
                int num = int.Parse(Console.ReadLine()) % 42;
                numList.Add(num);
            }

            for (int i = 0; i < lineCount; i++)
            {
                if (answerList.Contains(numList[i]))
                    continue;
                else
                    answerList.Add(numList[i]);
            }

            Console.WriteLine(answerList.Count);
        }
    }

    //바구니 뒤집기
    public class _10811번
    {
        //List.Reverse 사용
        static void Main()
        {
            string[] stringArray = Console.ReadLine().Split();

            int bagCount = int.Parse(stringArray[0]);
            int lineCount = int.Parse(stringArray[1]);

            List<int> bagList = new List<int>();

            for (int i = 0; i < bagCount; i++)
                bagList.Add(i + 1);

            for (int i = 0; i < lineCount; i++)
            {
                string[] sArray = Console.ReadLine().Split();

                int num1 = int.Parse(sArray[0]);
                int num2 = int.Parse(sArray[1]);

                bagList.Reverse(num1 - 1, num2 - num1 + 1);
            }

            for (int i = 0; i < bagList.Count; i++)
            {
                Console.Write(bagList[i] + " ");
            }
        }
    }

    //평균
    public class _1546번
    {
        //List.Max, List.Sum, stringFormat, float -> int 형변환 조심
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());  //과목 갯수

            List<float> scoreList = new List<float>();

            string[] stringArrray = Console.ReadLine().Split();

            for (int i = 0; i < count; i++)
            {
                scoreList.Add(int.Parse(stringArrray[i]));
            }

            float maxNum = scoreList.Max();

            for (int i = 0; i < count; i++)
            {
                scoreList[i] = scoreList[i] / maxNum * 100;
            }

            float result = scoreList.Sum() / scoreList.Count;

            Console.WriteLine("{0:0.00####}", result);
        }
    }

    //문자와 문자열
    public class _27866번
    {
        static void Main()
        {
            string word = Console.ReadLine();           //문자
            int num = int.Parse(Console.ReadLine());    //n번째

            Console.WriteLine(word[num - 1]);
        }
    }

    //단어 길이 재기
    public class _2743번
    {
        static void Main()
        {
            string word = Console.ReadLine();

            Console.WriteLine(word.Length);
        }
    }

    //문자열
    public class _9086번
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();

                Console.WriteLine($"{word[0]}{word[word.Length - 1]}");
            }
        }
    }

    //아스키 코드
    public class _11654번
    {
        static void Main()
        {
            char alphabet = Convert.ToChar(Console.ReadLine());

            int result = Convert.ToInt32(alphabet);

            Console.WriteLine(result);
        }
    }

    //숫자의 합
    public class _11720번
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            string value = Console.ReadLine();

            int result = 0;

            for(int i = 0; i < length; i++)
            {
                result += int.Parse(value[i].ToString());
            }

            Console.WriteLine(result);
        }
    }

    //알파벳 찾기
    public class _10809번
    {
        //아스키코드 97 : a, 122 : z
        static void Main()
        {
            string word = Console.ReadLine();

            for(int i = 97; i < 123; i++)
            {
                char c = Convert.ToChar(i);

                if(word.Contains(c))
                {
                    Console.Write(word.IndexOf(c));
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("-1 ");
                }
            }
        }
    }

    //문자열 반복
    public class _2675번
    {
        //StringBuilder.Append의 RepeatCount 사용
        static void Main()
        {
            int lineCount = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < lineCount; i++)
            {
                string[] stringArray = Console.ReadLine().Split();

                int count = int.Parse(stringArray[0]);
                string word = stringArray[1];

                for(int j = 0; j < word.Length; j++)
                {
                    sb.Append(word[j], count);
                }

                sb.Append("\n");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
