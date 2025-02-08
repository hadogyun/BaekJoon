using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //단어 정렬
    public class _1181번
    {
        //중복제거를 위해 List.Distinct 사용
        static void Main()
        {
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            StreamReader reader = new StreamReader(Console.OpenStandardInput());

            int count = int.Parse(reader.ReadLine());

            List<string> strList = new List<string>();

            for(int i = 0; i < count; i++)
            {
                strList.Add(reader.ReadLine());
            }

            var sorList = strList.Distinct().OrderBy(x => x.Length).ThenBy(x => x).ToList();

            for(int i = 0; i < sorList.Count; i++)
            {
                writer.WriteLine(sorList[i]);
            }

            writer.Close();
            reader.Close();
        }
    }

    //나이순 정렬
    public class _10814번
    {
        static void Main()
        {
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            StreamReader reader = new StreamReader(Console.OpenStandardInput());

            int count = int.Parse(reader.ReadLine());

            List<(int, string)> inputList = new List<(int, string)>();

            int num = 0;

            for(int i = 0; i < count; i++)
            {
                string[] strArray = reader.ReadLine().Split();

                int age = int.Parse(strArray[0]);
                string name = strArray[1];

                inputList.Add((age, name));

                num++;
            }

            var sortList = inputList.OrderBy(x => x.Item1).ToList();

            for(int i = 0; i < sortList.Count; i++)
            {
                writer.WriteLine($"{sortList[i].Item1} {sortList[i].Item2}");
            }

            writer.Close();
            reader.Close();
        }
    }

    //좌표 압축
    public class _18870번
    {
        static void Main()
        {
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            StreamReader reader = new StreamReader(Console.OpenStandardInput());

            int count = int.Parse((reader.ReadLine()));

            int[] intArray = Array.ConvertAll(reader.ReadLine().Split(), int.Parse);

            int[] sortList = new List<int>(intArray).ToArray();
            Array.Sort(sortList);

            Dictionary<int, int> dict = new Dictionary<int, int>();
            int index = 0;

            foreach(var value in sortList)
            {
                if(!dict.ContainsKey(value))
                {
                    dict[value] = index;
                    index++;
                }
            }

            for(int i = 0; i < count; i++)
            {
                writer.Write($"{dict[intArray[i]]} ");
            }

            writer.Close();
            reader.Close();
        }
    }
}
