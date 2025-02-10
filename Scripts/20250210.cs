using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //문자열 집합
    public class _14425번
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(Console.OpenStandardInput());
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());

            string[] input = reader.ReadLine().Split();

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            string[] strArray = new string[n];

            Dictionary<string, int> dic = new Dictionary<string, int>();

            int result = 0;

            for(int i = 0; i < n; i++)
            {
                strArray[i] = reader.ReadLine();
            }

            for(int i = 0; i < m; i++)
            {
                string temp = reader.ReadLine();
                if(dic.ContainsKey(temp))
                {
                    dic[temp]++;
                }
                else
                {
                    dic[temp] = 1;
                }
            }

            foreach(var item in strArray)
            {
                if(dic.ContainsKey(item))
                {
                    result += dic[item];
                }
            }

            writer.Write(result);
            writer.Flush();
            writer.Close();
            reader.Close();
        }
    }
}
