using System;

namespace FizzBuzzInTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzHelper fizzBuzzHelper = new FizzBuzzHelper();

            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzBuzzHelper.GetFizzBuzzByNumber(i));
            }

            Console.ReadLine();
        }
    }
}
