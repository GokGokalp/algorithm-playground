using System;
using System.Collections.Generic;

namespace ArrayComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 3, 1, 2, 4 };
            int[] b = new int[] { 1, 2, 5 };

            int[] output = GetCommonValues(a, b);

            Console.WriteLine(string.Join(',', Array.ConvertAll(output, c => c.ToString())));
        }

        static int[] GetCommonValues(int[] a, int[] b)
        {
            // Time complexity is O(n^2)
            int[] output = new int[a.Length]; // It can be List<int>
            int counter = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int y = 0; y < b.Length; y++)
                {
                    if (b[y] == a[i])
                    {
                        output[counter] = b[y];
                        counter++;
                    }
                }
            }

            Array.Resize<int>(ref output, counter);

            return output;
        }
    }
}