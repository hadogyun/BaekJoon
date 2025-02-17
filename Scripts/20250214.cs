using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //가로수
    public class _2485번
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter writer = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(reader.ReadLine());

            List<int> numList = new List<int>();
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(reader.ReadLine());
                numList.Add(num);
            }

            int gcd = numList[1] - numList[0];

            for (int i = 2; i < n; i++)
            {
                int gap = numList[i] - numList[i - 1];
                gcd = GCD(gcd, gap);
            }

            for (int i = 1; i < n; i++)
            {
                int gap = numList[i] - numList[i - 1];
                count += (gap / gcd) - 1;
            }

            writer.Write(count);

            reader.Close();
            writer.Close();
        }

        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}
