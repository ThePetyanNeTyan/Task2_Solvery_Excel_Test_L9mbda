using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
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

            ReadExcel("Ремонт все филиалы.xlsx");
        }

        private static void ReadExcel(string path)
        {
            using (var excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet firstWorksheet = excelPackage.Workbook.Worksheets[0];
                ExcelWorksheet secondtWorksheet = excelPackage.Workbook.Worksheets[1];
                ExcelWorksheet thridWorksheet = excelPackage.Workbook.Worksheets[2];
                ExcelWorksheet fourWorksheet = excelPackage.Workbook.Worksheets[3];
                ExcelWorksheet fiveWorksheet = excelPackage.Workbook.Worksheets[4];

                for (int i = 1; i <= firstWorksheet.Dimension.Rows; i++)
                {
                    for (int j = 1; j <= firstWorksheet.Dimension.Columns; j++)
                    {
                        Console.Write(firstWorksheet.Cells[i, j].Value + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void WriteExcel(string path, string fileName)
        {
            var fullPath = Path.Combine(path, fileName);
            
        }
    }


}