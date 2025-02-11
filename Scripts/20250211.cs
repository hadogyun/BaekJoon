using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //회사에 있는 사람
    public class _7785번
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int count = int.Parse(Console.ReadLine());

            Dictionary<string, string> dic = new Dictionary<string, string>();

            for (int i = 0; i < count; i++)
            {
                string[] strArray = Console.ReadLine().Split();

                string name = strArray[0];
                string status = strArray[1];

                if (dic.ContainsKey(name))
                    dic.Remove(name);
                else
                    dic.Add(name, status);
            }

            List<string> strList = new List<string>(dic.Keys);

            strList.Sort();
            strList.Reverse();

            foreach(string key in strList)
            {
                sb.AppendLine(key.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }

    //나는야 포켓몬 마스터 이다솜
    public class _1620번
    {
        //char.IsDigit() 으로 문자가 숫자인지 체크
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            string[] strArray = Console.ReadLine().Split();

            int count = int.Parse(strArray[0]);
            int problemCount = int.Parse(strArray[1]);

            Dictionary<string, string> dic = new Dictionary<string, string>();

            for(int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();

                dic.Add(name, (i + 1).ToString());
            }

            List<string> strList = new List<string>(dic.Keys);

            for(int i = 0; i < problemCount; i++)
            {
                string input = Console.ReadLine();

                if(char.IsDigit(input[0]))
                {
                    int key = int.Parse(input);
                    sb.AppendLine(strList[key - 1]);
                }
                else
                {
                    sb.AppendLine(dic[input]);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
