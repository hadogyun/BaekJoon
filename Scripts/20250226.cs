using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //제로
    public class _10773번
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter writer = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int count = int.Parse(reader.ReadLine());
            int sum = 0;

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(reader.ReadLine());

                if (num == 0)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(num);
                }
            }

            foreach (int i in stack)
            {
                sum += i;
            }

            writer.Write(sum);

            writer.Flush();
            writer.Close();
            reader.Close();
        }
    }
}
