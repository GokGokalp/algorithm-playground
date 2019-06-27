using System;
using System.Linq;

namespace AnagramDetection
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "abcd";
            string input2 = "dabc";

            bool result = AreAnagram(input1, input2);

            Console.WriteLine($"{input1} and {input2} are anagram: {result}");
        }

        static bool AreAnagram(string input1, string input2)
        {
            if (input1.Length != input2.Length)
            {
                return false;
            }

            input1 = string.Concat(input1.OrderBy(x => x)); // O(N log N) 
            input2 = string.Concat(input2.OrderBy(x => x));

            // O(n)
            for (int i = 0; i < input1.Length; i++)
            {
                if (input1[i] != input2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}