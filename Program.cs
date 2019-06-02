using System;
using System.IO;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] sprtr = { "\n", " ", ",", ".", ":", "\t", "/n" }; //Разделитель строк 
            string path = @"C:\text.txt"; //Переменная с расположением файла            
            StreamReader reader = new StreamReader(path, Encoding.UTF8); // Открываю файл
            string text = File.ReadAllText(path); // Сохраняю текст в строку
            string[] words = text.Split(sprtr, System.StringSplitOptions.RemoveEmptyEntries); // Разделяю строку на массивы и удаляю пустые массивы

            foreach (var word in words)
                Console.Write($"{word} "); // визуальный дебаг

            Console.WriteLine(words.Length); // длина массива, т.е количество слов в нём.

            reader.Close(); //закрываем поток
            Console.ReadLine();
        }
    }
}
