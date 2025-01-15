using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //팰린드롬인지 확인하기
    public class _10988번
    {
        static void Main()
        {
            string str = Console.ReadLine();

            string tempStr = new string(str.Reverse().ToArray());

            if (tempStr == str)
                Console.WriteLine("1");
            else
                Console.WriteLine("0");
        }
    }

    //단어 공부
    public class _1157번
    {
        static int[] answer = new int[26];
        static char[] alphabet = new char[26];

        static void Main()
        {
            //알파벳 배열에 담기
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)((int)'A' + i);
            }

            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = 0;
            }

            string str = Console.ReadLine().ToUpper();      //출력을 대문자로 해야하므로 값을 받아오면서 대문자로 변경

            Count(str);

            Console.WriteLine(Result());
        }

        static void Count(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (str[i] == alphabet[j])
                    {
                        answer[j]++;
                    }
                }
            }
        }

        static char Result()
        {
            int index = 0;

            int high = 0;

            bool same = false;

            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == high && answer[i] != 0)
                    same = true;

                if (answer[i] > high)
                {
                    high = answer[i];
                    index = i;
                    same = false;
                }
            }

            if (same)
                return '?';
            else
                return alphabet[index];
        }
    }

    //크로아티아 알파벳
    public class _2941번
    {
        static void Main()
        {
            string[] croatiaAlphabets = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };

            string str = Console.ReadLine();

            foreach (string alphabet in croatiaAlphabets)
            {
                while (str.Contains(alphabet))
                {
                    str = str.Replace(alphabet, "a");
                }
            }

            Console.WriteLine(str.Length);
        }
    }

    //그룹 단어 체커
    public class _1316번
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            string[] stringArray = new string[count];

            int result = 0;

            for (int i = 0; i < count; i++)
            {
                stringArray[i] = Console.ReadLine();
            }

            for (int i = 0; i < count; i++)
            {
                if (CheckGroupWord(stringArray[i]))
                    result++;
            }

            Console.WriteLine(result);
        }

        static bool CheckGroupWord(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = i; j < word.Length; j++)
                {
                    if (j - i > 1)
                    {
                        if (word[i] == word[j])
                        {
                            return false;
                        }
                    }
                    if (word[i] == word[j])
                    {
                        i += j - i;
                    }
                }
            }
            return true;
        }
    }

    //너의 평점은
    public class _25206번
    {
        static Dictionary<string, float> scoreDic = new Dictionary<string, float>();

        static void Init()
        {
            scoreDic.Add("A+", 4.5f);
            scoreDic.Add("A0", 4.0f);
            scoreDic.Add("B+", 3.5f);
            scoreDic.Add("B0", 3.0f);
            scoreDic.Add("C+", 2.5f);
            scoreDic.Add("C0", 2.0f);
            scoreDic.Add("D+", 1.5f);
            scoreDic.Add("D0", 1.0f);
            scoreDic.Add("F", 0.0f);
        }

        static void Main()
        {
            Init();

            float count = 0;
            float result = 0.0f;

            for (int i = 0; i < 20; i++)
            {
                string str = Console.ReadLine();
                string[] stringArray = str.Split();

                if (stringArray[2] == "P" || str.Length == 0)
                    continue;

                float score = float.Parse(stringArray[1]);
                string dicKey = stringArray[2];

                count += score;
                result += score * scoreDic[dicKey];
            }

            result /= count;

            Console.WriteLine(result);
        }
    }
}
