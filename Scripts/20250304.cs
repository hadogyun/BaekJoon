using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //균형잡힌 세상
    public class _4949번
    {
        static void Main()
        {
            while (true)
            {
                string str = Console.ReadLine();

                if (str.Length == 1 && str[0] == '.') break;

                bool isPaired = true;
                var stack = new Stack<char>();
                foreach (var c in str)
                {
                    if (c == '(' || c == '[')
                        stack.Push(c);

                    if (c == ')')
                    {
                        if (stack.Count == 0 || stack.Peek() == '[')
                            isPaired = false;
                        else stack.Pop();
                    }

                    if (c == ']')
                    {
                        if (stack.Count == 0 || stack.Peek() == '(')
                            isPaired = false;
                        else stack.Pop();
                    }
                }

                if (stack.Count == 0 && isPaired)
                    Console.WriteLine("yes");
                else
                    Console.WriteLine("no");
            }
        }
    }
}
