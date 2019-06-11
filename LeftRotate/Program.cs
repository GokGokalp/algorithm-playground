using System.Linq;
using System;

namespace LeftRotate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 1, 2, 3, 4, 5 };

            int[] output = RotLeft(input, 2);

            Console.WriteLine(string.Join(',', Array.ConvertAll(output, c => c.ToString())));
        }

        static int[] RotLeft(int[] a, int d)
        {
            int[] output = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                output[i] = a[(i + d) % a.Length];
            }

            return output;
        }
    }
}
