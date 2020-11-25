using System;

namespace _04._Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            string filterCode = string.Empty;
            

            for (int i = 0; i < input.Length; i++)
            {

                switch (input[i])
                {
                    case ".-":
                        filterCode += 'A';
                        break;
                    case "-...":
                        filterCode += 'B';
                        break;
                    case "-.-.":
                        filterCode += 'C';
                        break;
                    case "-..":
                        filterCode += 'D';
                        break;
                    case ".":
                        filterCode += 'E';
                        break;
                    case "..-.":
                        filterCode += 'F';
                        break;
                    case "--.":
                        filterCode += 'G';
                        break;
                    case "....":
                        filterCode += 'H';
                        break;
                    case "..":
                        filterCode += 'I';
                        break;
                    case ".---":
                        filterCode += 'J';
                        break;
                    case "-.-":
                        filterCode += 'K';
                        break;
                    case ".-..":
                        filterCode += 'L';
                        break;
                    case "--":
                        filterCode += 'M';
                        break;
                    case "-.":
                        filterCode += 'N';
                        break;
                    case "---":
                        filterCode += 'O';
                        break;
                    case ".--.":
                        filterCode += 'P';
                        break;
                    case "--.-":
                        filterCode += 'Q';
                        break;
                    case ".-.":
                        filterCode += 'R';
                        break;
                    case "...":
                        filterCode += 'S';
                        break;
                    case "-":
                        filterCode += 'T';
                        break;
                    case "..-":
                        filterCode += 'U';
                        break;
                    case "...-":
                        filterCode += 'V';
                        break;
                    case ".--":
                        filterCode += 'W';
                        break;
                    case "-..-":
                        filterCode += 'X';
                        break;
                    case "-.--":
                        filterCode += 'Y';
                        break;
                    case "--..":
                        filterCode += 'Z';
                        break;
                    case "|":
                        filterCode += ' ';
                        break;

                }

            }
           
            Console.WriteLine(filterCode);
        }
    }
}
