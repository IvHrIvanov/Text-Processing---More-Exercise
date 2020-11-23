using System;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstSymbol = Console.ReadLine();
            string secondSymbol = Console.ReadLine();
            string randomText = Console.ReadLine();
                     
            int startIndex = firstSymbol[0];
            int endIndex = secondSymbol[0];

            int sum = 0;

            for (int i = 0; i < randomText.Length; i++)
            {
                int currentLeter = randomText[i];

                if (currentLeter > startIndex && currentLeter < endIndex)
                {
                    sum += currentLeter;
                }

            }

            Console.WriteLine(sum);

        }
    }
}