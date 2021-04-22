using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2_Solvery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "Воронеж", "Коломна", "Луховицы", "Киев", "Москва",
            "Воскресенск", "Бронницы", "Ульяновск", "Минск", "Молодечно", "Иваново", "Клин"};

            var element = list.First(x => x.Length == 9); // длина города 9
            Console.WriteLine(element);

            var element2 = list.FirstOrDefault(x => x.Contains("ъ")); // город содержит ъ
            Console.WriteLine(element2);

            var element3 = list.LastOrDefault(x => x.Length == 3); // последний город который содержит 3 буквы
            Console.WriteLine(element3);

            var element4 = list.Where(x => x.Contains('о'));  // все города, которые содержат о
            foreach (var item in element4)
            {
                Console.Write(item + ' ');
            }

            Console.WriteLine();

            var element5 = list.OrderByDescending(x => x.Length); // сортировка городов по убыванию
            foreach (var item in element5)
            {
                Console.Write(item + ' ');
            }

            Console.WriteLine();

            var element6 = list.Where(x => x.StartsWith('В')).OrderBy(x => x.Length).Last(); // начинаются на В сортировка по возрастанию берем последний
            Console.WriteLine(element6);
        }
    }


}