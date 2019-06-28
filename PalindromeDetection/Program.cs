using System;

namespace PalindromeDetection
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "madam";

            bool result = IsPalindrome(input);

            Console.WriteLine($"{input} is palindrome: {result}");
        }

        static bool IsPalindrome(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return false;
            }

            bool result = true;

            // O(N)
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != input[(input.Length - 1) - i])
                {
                    result = false;
                }
            }

            return result;
        }
    }
}
