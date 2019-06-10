using System;
using System.Text;

namespace StringCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "AAABBZZDDD";

            string output = CompressString(input);

            Console.WriteLine(output);
            Console.ReadLine();
        }

        static string CompressString(string input)
        {
            char[] charArr = input.ToCharArray();
            char prev = charArr[0];
            int count = 1;
            StringBuilder sBuilder = new StringBuilder();

            //Time complexity is O(N)
            for (int i = 1; i < charArr.Length; i++)
            {
                if (charArr[i] == prev)
                {
                    count += 1;
                }
                else
                {
                    sBuilder.Append(prev);
                    sBuilder.Append(count);

                    prev = charArr[i];
                    count = 1;
                }
            }

            sBuilder.Append(prev);
            sBuilder.Append(count);

            return sBuilder.ToString();
        }
    }
}
