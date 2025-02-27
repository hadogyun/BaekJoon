using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //괄호
    public class _9012번
    {
        static void Main()
        {
			StringBuilder sb = new StringBuilder();

			Stack<char> stack = new Stack<char>();
			int count = int.Parse(Console.ReadLine());

			while (count-- > 0)
			{
				char[] str = Console.ReadLine().ToCharArray();     

				foreach (char c in str)
				{
					if (c == '(') { stack.Push(c); }                                    
					else if (c == ')' && stack.Count > 0) { stack.Pop(); }              
					else if (c == ')' && stack.Count == 0) { stack.Push(c); break; }    
				}

				if (stack.Count == 0) { sb.AppendLine("YES"); }        
				else if (stack.Count > 0) { sb.AppendLine("NO"); }     

				stack.Clear();
			}

			Console.Write(sb);
		}
    }
}
