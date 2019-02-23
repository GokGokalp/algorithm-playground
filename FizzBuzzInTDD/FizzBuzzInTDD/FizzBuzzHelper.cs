using System;

namespace FizzBuzzInTDD
{
    public class FizzBuzzHelper
    {
        public bool IsDivisableThree(int number)
        {
            return (number % 3) == 0;
        }

        public bool IsDivisableFive(int number)
        {
            return (number % 5) == 0;
        }

        public string GetFizzBuzzByNumber(int number)
        {
            if (IsDivisableThree(number) && IsDivisableFive(number))
            {
                return "FizzBuzz";
            }
            else if (IsDivisableThree(number))
            {
                return "Fizz";
            }
            else if (IsDivisableFive(number))
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}