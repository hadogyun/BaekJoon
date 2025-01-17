using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.Scripts
{
    //진법 변환
    public class _2745번
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();

            string num = strArray[0];

            int form = int.Parse(strArray[1]);

            int result = ConvertToDecimal(num, form);

            Console.WriteLine(result);
        }

        static int ConvertToDecimal(string number, int baseFrom)
        {
            int result = 0;

            int power = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                char digit = number[i];
                int value;

                if (Char.IsDigit(digit))
                {
                    value = digit - '0';
                }
                else
                {
                    value = Char.ToUpper(digit) - 'A' + 10;
                }

                result += value * (int)Math.Pow(baseFrom, power);
                power++;
            }

            return result;
        }
    }

    //진법 변환 2
    public class _11005번
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            int decimalNum = int.Parse(input[0]);
            
            int convertBaseNum = int.Parse(input[1]);

            Console.WriteLine(ConvertToBase(decimalNum, convertBaseNum));
        }

        static string ConvertToBase(int decimalNum, int convertBaseNum)
        {
            int currentNum = decimalNum;

            int remain = 0;
            
            string result = "";

            while (true)
            {
                remain = currentNum % convertBaseNum;

                currentNum = currentNum / convertBaseNum;

                if (convertBaseNum > 10 && remain > 9)
                {
                    char temp = (char)(remain - 10 + 'A');
                    result = temp + result;
                }
                else
                {
                    result = remain.ToString() + result;
                }
                
                if (currentNum == 0)
                {
                    return result;
                }
            }
        }
    }

    //세탁소 사장 동혁
    public class _2720번
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int money = int.Parse(Console.ReadLine());

                int quarter = money / 25;
                money %= 25;

                int dime = money / 10;
                money %= 10;
                
                int nickel = money / 5;
                money %= 5;
                
                int penny = money;

                Console.WriteLine($"{quarter} {dime} {nickel} {penny}");
            }
        }
    }
}
