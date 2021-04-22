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
            "Воскресенск", "Бронницы", "Ульяновск", "Минск", "Молодечно", "Иваново", "Клин" };

            var element = list.First(x => x.Length == 9);
            Console.WriteLine(element);
        }
    }


}