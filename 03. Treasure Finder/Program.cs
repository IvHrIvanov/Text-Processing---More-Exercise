using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split(" ")
                                                .Select(int.Parse)
                                                .ToArray();
            string code = Console.ReadLine();

            Dictionary<string, string> cordinates = new Dictionary<string, string>();

            while (code != "find")
            {
                string findCode = string.Empty;
                int currentKey = 0;

                for (int i = 0; i < code.Length; i++)
                {

                    string currentLetter = code[i].ToString();
                    int currentCode = code[i] - key[currentKey];
                    findCode += (char)currentCode;
                    currentKey++;

                    if (currentKey >= key.Length)
                    {
                        currentKey = 0;
                    }
                }
                
                int firstIndex = findCode.IndexOf('&');
                int secondIndex = findCode.IndexOf('&', firstIndex + 1);

                int cordinateIndex = findCode.IndexOf('<');
                int cordinateEndIndex = findCode.IndexOf('>');

                string type = findCode.Substring(firstIndex + 1, secondIndex - firstIndex - 1);
                string cordinate = findCode.Substring(cordinateIndex + 1, cordinateEndIndex - cordinateIndex - 1);
                cordinates.Add(type, cordinate);

                code = Console.ReadLine();

            }
            foreach (var item in cordinates)
            {
                Console.WriteLine($"Found {item.Key} at {item.Value}");
            }
        }
    }
}