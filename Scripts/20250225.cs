using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //스택 2
    public class _28278번
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            Stack<string> strStack = new Stack<string>(count);

            for (int i = 0; i < count; i++)
            {
                string[] strArray = Console.ReadLine().Split();

                if (strArray[0] == "1")
                {
                    strStack.Push(strArray[1]);
                }
                else if (strArray[0] == "2")
                {
                    if (strStack.Count > 0)
                        sb.Append(strStack.Pop() + "\n");
                    else
                        sb.Append("-1" + "\n");
                }
                else if (strArray[0] == "3")
                {
                    sb.Append(strStack.Count + "\n");
                }
                else if (strArray[0] == "4")
                {
                    if (strStack.Count > 0)
                        sb.Append("0" + "\n");
                    else
                        sb.Append("1" + "\n");
                }
                else if (strArray[0] == "5")
                {
                    if (strStack.Count > 0)
                        sb.Append(strStack.Peek() + "\n");
                    else
                        sb.Append("-1" + "\n");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
