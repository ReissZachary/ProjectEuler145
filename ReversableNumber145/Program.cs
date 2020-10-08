using System;

namespace ReversableNumber145
{
    public class Program
    {
        static void Main(string[] args)
        {
            double billion = Math.Pow(10, 9);

            int reversableNumbers = 0;

            for(int number = 1; number < billion; number++)
            {
                int addedNumberWithFlipped = ReverseNumbers.AddNumberWithFlip(number);

                if (ReverseNumbers.AllDigitsAreOdd(addedNumberWithFlipped))
                {
                    if (number % 10 == 0)
                    {
                        //do nothing
                    }
                    else
                    {                        
                        reversableNumbers++;
                    }
                }
            }

            Console.WriteLine($"There are {reversableNumbers} reversable numbers below one-billion");
        }
    }
}
