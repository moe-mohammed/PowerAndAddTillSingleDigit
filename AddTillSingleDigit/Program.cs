using System;
using System.Collections.Generic;

namespace AddTillSingleDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = 11;
            int singleDigitResult = AddTillOneDigit(power);
            Console.WriteLine(singleDigitResult);
            Console.ReadLine();
        }

        public static int AddTillOneDigit(int power)
        {
            int total = (int)Math.Pow(2, power);
            string finalNumberString = "";

            while (finalNumberString.Length != 1)
            {
                char[] totalCharArray = total.ToString().ToCharArray();
                List<int> numbersList = new List<int>() { };

                foreach (char character in totalCharArray)
                {
                    int number = (int)Char.GetNumericValue(character);
                    numbersList.Add(number);
                }

                int numbersTotal = 0;
                foreach (int number in numbersList)
                {
                    numbersTotal += number;
                }

                total = numbersTotal;
                finalNumberString = total.ToString();
            }

            return total;
        }
    }
}
