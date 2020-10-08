using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReversableNumber145
{
    public class ReverseNumbers
    {
        public static int FlipNumber(int number)
        {
            int reminder;
            int reverse = 0;

            while (number > 0)
            {
                //Get the remainder by dividing the number with 10  
                reminder = number % 10;
                //multiply the sum with 10 and then add the reminder
                reverse = (reverse * 10) + reminder;
                //Get the quotient by dividing the number with 10 
                number /= 10;
            }

            return reverse;
        }

        public static int AddNumberWithFlip(int number) => number + FlipNumber(number);

        public static bool AllDigitsAreOdd(int number)
        {
            var digits = GetDigits(number);
            int numOfOddDigits = 0;

            foreach(var digit in digits)
            {
                if(digit % 2 == 0)
                {
                    //digit is even
                    return false;
                }
                else
                {
                    //digit is odd
                    numOfOddDigits++;
                }
            }
            
            if(numOfOddDigits == digits.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<int> GetDigits(int num)
        {
            var digits = new List<int>();

            while (num > 0)
            {
                var digit = num % 10;
                num /= 10;
                digits.Add(digit);
            }

            return digits;
        }
    }
}
