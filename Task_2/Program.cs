using System;

namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            string inputText = InputData();

            string[] textWords = InputProcessing(inputText);

            Console.WriteLine("\nИзмененный вид массива слов:\n");
            OutputResult(textWords);

            Console.ReadKey();
        }

        /// <summary>
        /// Получение данных от пользователя
        /// </summary>
        /// <returns></returns>
        static string InputData()
        {
            Console.WriteLine("Введите текст:");
            string input = InputChecking();

            return input;
        }

        /// <summary>
        /// Проверка на пустое поле ввода
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Отображение изначального массива и его зеркальное отображение
        /// </summary>
        /// <param name="input"> Введенная пользователем информация </param>
        /// <returns> Зеркальный массив </returns>
        static string[] InputProcessing(string input)
        {
            //Создание массива
            string[] tempTextWords = CraeteNewArray(input);

            Console.WriteLine("\nИзначальный вид массива слов:\n");
            OutputResult(tempTextWords);

            int LastIndex = tempTextWords.Length - 1, FirstIndex = 0;
            //Обмен элементов
            if (LastIndex != 0)
            {
                string tempWord;

                while (LastIndex > FirstIndex)
                {
                    tempWord = tempTextWords[FirstIndex];
                    tempTextWords[FirstIndex] = tempTextWords[LastIndex];
                    tempTextWords[LastIndex] = tempWord;

                    FirstIndex++;
                    LastIndex--;
                }
            }

            return tempTextWords;
        }

        /// <summary>
        /// Обработка массива на наличие пустых элементов
        /// </summary>
        /// <param name="input"> Введенная пользователем информация </param>
        /// <returns> Обработанный массив </returns>
        static string[] CraeteNewArray(string input)
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
                for (int j = 0; j < tempArray.Length; j++)
                {
                    if (tempArray[j].Trim() != "")
                    {
                        tempTextWords[i] = tempArray[j];
                        tempArray[j] = "";
                        break;
                    }
                }
            }
            return tempTextWords;
        }

        /// <summary>
        /// Вывод результата
        /// </summary>
        /// <param name="words"> Обработанный массив </param>
        static void OutputResult(string[] words)
        {
            int arrayLenght = words.Length;
            for (int i = 0; i < arrayLenght; i++)
            {
                Console.WriteLine($"{i + 1} - {words[i]}");
            }
        }
    }
}
