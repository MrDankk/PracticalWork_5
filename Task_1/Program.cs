using System;

namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            string inputText = InputData();

            string[] textWords = SplitText(inputText);
            
            OutputResult(textWords);

            Console.ReadKey();
        }


        static string InputData()
        {
            Console.WriteLine("Введите текст:");
            string input = InputChecking();

            return input;
        }

        static string InputChecking()
        {
            string _input = Console.ReadLine().Trim();

            while (true)
            {
                if (_input == "")
                {
                    Console.WriteLine("\nПопробуйте еще раз\n");
                    _input = Console.ReadLine().Trim();
                }
                else
                {
                    return _input;
                }
            }
        }

        static string[] SplitText(string input)
        {
            string[] tempArray = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            return tempArray;
        }

        static void OutputResult(string[] words)
        {
            int arrayLenght = words.Length;
            Console.WriteLine($"\nВ тексте {arrayLenght} слов:\n");

            for (int i = 0; i < arrayLenght; i++)
            {
                Console.WriteLine($"{i+1} - {words[i]}");
            }
        }

    }
}
