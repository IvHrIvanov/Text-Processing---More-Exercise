using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> person = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                int indexOfNameStart = input.IndexOf('@');
                int indexoFNameEnd = input.IndexOf('|');
                string name = input.Substring(indexOfNameStart + 1, indexoFNameEnd - indexOfNameStart - 1);
                int ageStartIndex = input.IndexOf('#');
                int ageEndIndex = input.IndexOf('*');
                string age = input.Substring(ageStartIndex + 1, ageEndIndex - ageStartIndex - 1);
                Console.WriteLine($"{name} is {age} years old.");

            }

        }
    }
}