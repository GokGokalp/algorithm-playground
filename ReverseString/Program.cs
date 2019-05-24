using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World";

            string reversedInput = Reverse(input);

            Console.WriteLine(reversedInput);
            Console.ReadKey();
        }

        static string Reverse(string input)
        {
            // Time complexity O(N)
            string[] inputArr = input.Split(" ");
            string reversedInput = string.Empty;

            for (int i = inputArr.Length -1; i >= 0; i--)
            {
                reversedInput += inputArr[i] + " ";
            }

            reversedInput = reversedInput.Substring(0, reversedInput.Length -1);
            return reversedInput;
        }
    }
}