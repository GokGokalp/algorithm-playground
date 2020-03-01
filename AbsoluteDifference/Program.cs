using System;

namespace AbsoluteDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int differences = GetAbsoluteDifference(n);

            Console.WriteLine($"Absolute differences is: {differences}");
        }

        static int GetAbsoluteDifference(int n)
        {
            const int x = 43;

            if (n > x)
            {
                return (n - x) * 2;
            }

            return x - n;
        }
    }
}