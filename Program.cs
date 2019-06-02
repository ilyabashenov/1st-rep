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


            string[] wordSeparators = { "\n", " ", ",", ".", ":", "\t", "/n" }; //Разделитель строк 
            Dictionary<string, int> wordCointerDictionary = new Dictionary<string, int>(); // Словарь

            string path = @"C:\text.txt"; //Переменная с расположением файла            
            //using (StreamReader reader = new StreamReader(path, Encoding.UTF8))// в using только получение ресурсов. И надо тогда через ридер
            
                string text = File.ReadAllText(path); // Сохраняю текст в строку
                string[] words2 = text.Split(wordSeparators, System.StringSplitOptions.RemoveEmptyEntries); // Разделяю строку на массивы и удаляю пустые массивы

                for (int i = 0; i < words2.Length; i++)
                {
                    words2[i] = words2[i].ToLower(); // Перевожу в нижний регистр, чтобы сравнение было корректным 
                    if (!wordCointerDictionary.ContainsKey(words2[i])) // Если слова нет в словаре 
                    wordCointerDictionary.Add(words2[i], 1); // Добавляет
                    else wordCointerDictionary[words2[i]] += 1; // Иначе добавляет значение
                }

                foreach (var word in wordCointerDictionary)
                    Console.Write($"{word} "); // Вывод информации


            
            
        }
    }
}
