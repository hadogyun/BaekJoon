using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //A + B - 5
    public class _10952번
    {
        static void Main()
        {
            int a = 0;
            int b = 0;

            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string[] stringArray = Console.ReadLine().Split();

                if (stringArray.Length == 0)
                    break;

                a = int.Parse(stringArray[0]);
                b = int.Parse(stringArray[1]);

                if (a <= 0 || b >= 10)
                    break;

                sb.Append(a + b + "\n");
            }

            Console.WriteLine(sb.ToString());
        }
    }

    //A + B - 4
    public class _10951번
    {
        static void Main()
        {
            int a = 0;
            int b = 0;

            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == null)
                    break;

                string[] stringArray = input.Split();

                a = int.Parse(stringArray[0]);
                b = int.Parse(stringArray[1]);

                if (a <= 0 || b >= 10)
                    break;

                sb.Append(a + b + "\n");
            }

            Console.WriteLine(sb.ToString());
        }
    }

    //개수 세기
    public class _10807번
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            string[] stringArray = Console.ReadLine().Split();

            int findNum = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(stringArray[i]);

                if (findNum == num)
                    result++;
            }

            Console.WriteLine(result);
        }
    }

    //X보다 작은 수
    public class _10871번
    {
        static void Main()
        {
            string[] stringArray = Console.ReadLine().Split();

            int n = int.Parse(stringArray[0]);
            int x = int.Parse(stringArray[1]);

            string[] stringArray2 = Console.ReadLine().Split();

            StringBuilder sb = new StringBuilder();

            int result = 0;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(stringArray2[i]);

                if (x > a)
                    sb.Append(a + " ");
            }

            Console.WriteLine(sb.ToString());
        }
    }

    //최소, 최대
    public class _10818번
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            string[] stringArray = Console.ReadLine().Split();

            int biggest = int.Parse(stringArray[0]);
            int smallest = int.Parse(stringArray[0]);

            for (int i = 0; i < count; i++)
            {
                int a = int.Parse(stringArray[i]);

                if (a > biggest)
                    biggest = a;

                if (a < smallest)
                    smallest = a;
            }

            Console.WriteLine($"{smallest} {biggest}");
        }

        // cf) Sort 사용하면 좀더 편하지 않을까?
    }

    //최댓값
    public class _2562번
    {
        static void Main()
        {
            int[] intArray = new int[9];

            int biggest = 0;
            int num = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] > biggest)
                {
                    biggest = intArray[i];
                    num = i + 1;
                }
            }

            Console.WriteLine($"{biggest}\n{num}");
        }
    }

    //공 넣기
    public class _10810번
    {
        static void Main()
        {
            string[] stringArray = Console.ReadLine().Split();

            int bagCount = int.Parse(stringArray[0]);
            int lineCount = int.Parse(stringArray[1]);

            int[] intArray = new int[bagCount];

            for (int i = 0; i < bagCount; i++)
            {
                intArray[i] = 0;
            }

            for (int i = 0; i < lineCount; i++)
            {
                string[] numArray = Console.ReadLine().Split();
                int bagNum1 = int.Parse(numArray[0]);
                int bagNum2 = int.Parse(numArray[1]);
                int ballNum = int.Parse(numArray[2]);

                for (int j = bagNum1; j <= bagNum2; j++)
                {
                    intArray[j - 1] = ballNum;
                }
            }

            for (int i = 0; i < bagCount; i++)
            {
                Console.Write(intArray[i] + " ");
            }
        }
    }

    //공 바꾸기
    public class _10813번
    {
        static void Main()
        {
            string[] stringArray = Console.ReadLine().Split();

            int bagCount = int.Parse(stringArray[0]);
            int lineCount = int.Parse(stringArray[1]);

            int[] intArray = new int[bagCount];

            for (int i = 0; i < bagCount; i++)
            {
                intArray[i] = i + 1;
            }

            for (int i = 0; i < lineCount; i++)
            {
                string[] line = Console.ReadLine().Split();
                int bagA = int.Parse(line[0]) - 1;
                int bagB = int.Parse(line[1]) - 1;

                int saveNum = intArray[bagA];

                intArray[bagA] = intArray[bagB];
                intArray[bagB] = saveNum;
            }

            for (int i = 0; i < bagCount; i++)
            {
                Console.Write(intArray[i] + " ");
            }
        }
    }

    //과제 안 내신 분..?
    public class _5597번
    {
        static void Main()
        {
            int totalStudents = 30;     //총 학생수
            int doHomework = 28;        //숙제 제출한 학생수

            int[] students = new int[totalStudents];

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = 0;    //초기화
            }

            for(int i = 0; i < doHomework; i++)
            {
                int studentNum = int.Parse(Console.ReadLine()) - 1; //출석번호가 1번부터기 때문에 -1

                students[studentNum] = 1;
            }

            int smallNum = 0;
            int bigNum = 0;

            for(int i = 0; i < students.Length; i++)
            {
                if (students[i] == 0)
                {
                    if(smallNum == 0)
                        smallNum = i + 1;   //출석번호가 1번부터 때문에 +1
                    else
                        bigNum = i + 1;
                }
            }

            Console.WriteLine($"{smallNum}\n{bigNum}");
        }
    }
}
