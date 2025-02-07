using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //소트인사이드
    public class _1427번
    {
        static void Main()
        {
            string num = Console.ReadLine();

            int[] intArray = num.Select(_ => int.Parse(_.ToString())).ToArray();

            Array.Sort(intArray);
            Array.Reverse(intArray);

            string result = "";

            for (int i = 0; i < intArray.Length; i++)
            {
                result += intArray[i].ToString();
            }

            Console.Write(result);
        }
    }

    //좌표 정렬하기
    public class _11650번
    {
        static void Main()
        {
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            StreamReader reader = new StreamReader(Console.OpenStandardInput());

            List<(int, int)> intList = new List<(int, int)>();

            int count = int.Parse(reader.ReadLine());

            for(int i = 0; i < count; i++)
            {
                string[] strArray = reader.ReadLine().Split();

                int x = int.Parse(strArray[0]);
                int y = int.Parse(strArray[1]);

                intList.Add((x, y));
            }

            var sortList = intList.OrderBy(x => x.Item1).ThenBy(y => y.Item2).ToList();

            for(int i = 0; i < sortList.Count; i++)
            {
                writer.WriteLine($"{sortList[i].Item1} {sortList[i].Item2}");
            }

            writer.Close();
            reader.Close();
        }
    }

    //좌표 정렬하기 2
    public class _11651번
    {
        static void Main()
        {
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            StreamReader reader = new StreamReader(Console.OpenStandardInput());

            List<(int, int)> intList = new List<(int, int)>();

            int count = int.Parse(reader.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] strArray = reader.ReadLine().Split();

                int x = int.Parse(strArray[0]);
                int y = int.Parse(strArray[1]);

                intList.Add((x, y));
            }

            var sortList = intList.OrderBy(y => y.Item2).ThenBy(x => x.Item1).ToList();

            for (int i = 0; i < sortList.Count; i++)
            {
                writer.WriteLine($"{sortList[i].Item1} {sortList[i].Item2}");
            }

            writer.Close();
            reader.Close();
        }
    }
}
