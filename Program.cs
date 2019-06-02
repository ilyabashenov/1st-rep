using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] sprtr = { "\n", " ", ",", ".", ":", "\t", "/n" }; //Разделитель строк 
            Dictionary<string, int> words = new Dictionary<string, int>(); // Словарь

            string path = @"C:\text.txt"; //Переменная с расположением файла            
            using (StreamReader reader = new StreamReader(path, Encoding.UTF8))// Открываю файл через Using
            {
                string text = File.ReadAllText(path); // Сохраняю текст в строку
                string[] words2 = text.Split(sprtr, System.StringSplitOptions.RemoveEmptyEntries); // Разделяю строку на массивы и удаляю пустые массивы

                for (int i = 0; i < words2.Length; i++)
                {
                    words2[i]= words2[i].ToLower(); // Перевожу в нижний регистр, чтобы сравнение было корректным 
                    if (!words.ContainsKey(words2[i])) // Если слова нет в словаре 
                        words.Add(words2[i], 1); // Добавляет
                    else words[words2[i]] += 1; // Иначе добавляет значение
                }

                foreach (var word in words)
                    Console.Write($"{word} "); // Вывод информации

              

            }
        }
    }
}
