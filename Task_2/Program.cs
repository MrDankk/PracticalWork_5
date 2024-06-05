using System;

namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            string inputText = InputData();

            string[] wordsArray = SplitText(inputText);

            string resultText = CollectText(wordsArray);

            Console.WriteLine("\nПеревернутый текст: ");
            OutputResult(resultText);

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
            string[] textArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            ReverseArray(textArray);
            return textArray;
        }

        static void ReverseArray(string[] textArray)
        {
           Array.Reverse(textArray);
        }

        static string CollectText(string[] textArray)
        {
            return string.Join(" ", textArray);
        }

        static void OutputResult(string textResult)
        {
            Console.WriteLine($"\n{textResult}");
        }
    }
}
