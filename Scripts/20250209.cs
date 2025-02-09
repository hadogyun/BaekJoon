using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //숫자 카드
    public class _10815번
    {
        //시간 초과 주의
        static void Main()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();

            int count = int.Parse(sr.ReadLine());
            string[] strArray = sr.ReadLine().Split();
            HashSet<int> intHash = strArray.Select(int.Parse).ToHashSet();

            int count2 = int.Parse(sr.ReadLine());
            string[] strArray2 = sr.ReadLine().Split();
            HashSet<int> intHash2 = strArray2.Select(int.Parse).ToHashSet();

            foreach (int i in intHash2)
            {
                bool check = intHash.Contains(i);
                sb.Append(check ? 1 : 0);
                sb.Append(" ");
            }

            sw.Write(sb);
            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}
