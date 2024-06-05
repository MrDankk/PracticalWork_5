using System;

namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            string inputText = InputData();

            string[] textWords = InputProcessing(inputText);
            
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

        static string[] InputProcessing(string input)
        {
            //Создание массива
            string[] tempArray = input.Split(' ');

            //Подсчёт не пустых элементов массива
            int newArrayLength = 0;

            for (int i = 0; i < tempArray.Length; i++)
            {
                if (tempArray[i].Trim() == "")
                {
                    continue;
                }
                else
                {
                    newArrayLength++;
                }
            }

            //Создание нового массива и заполнение не пустыми значениями
            string[] tempTextWords = new string[newArrayLength];

            for (int i = 0; i < tempTextWords.Length; i++)
            {
                for (int j = 0; j < tempArray.Length;j++)
                {
                    if(tempArray[j].Trim() != "")
                    {
                        tempTextWords[i] = tempArray[j];
                        tempArray[j] = "";
                        break;
                    }
                }
            }

            return tempTextWords;
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
