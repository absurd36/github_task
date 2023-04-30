using System;
using System.Security.Cryptography;

namespace Prac5
{
    public class Program
    {
        private enum Software
        {
            Chrome,
            Firefox,
            Edge,
            Safari,
            VisualStudio,
            Eclipse,
            IntelliJIDEA,
            NetBeans
        }

        private static void Main()
        {
        again:
            Console.WriteLine("The work was done by Makarchuk M. V.\n");
            Console.WriteLine("The list of software products: ");

            foreach (Software value in Enum.GetValues(typeof(Software)))
            {
                if ((int)value == 0) Console.WriteLine("---BROWSERS---");
                else if ((int)value == 4) Console.WriteLine("---IDE---");

                Console.WriteLine($"#{(int)value}: {value}");
            }

            Console.Write("\nEnter the numbers of software products that you find popular and convenient (separate numbers with commas): ");

            string text = Console.ReadLine();

            // Перевірка на те, чи є серед уведених користувачем даних некоректні
            if (!double.TryParse(text.Replace(",", ""), out _))
            {
                Console.WriteLine("\nYOU MUST ENTER A NUMBER FROM 0 to 7!\n");

                goto again;
            }

            var numbers = text.Split(',').Select(int.Parse).Distinct().ToList();

            // Перевірка на те, чи є серед уведених користувачем чисел такі, що менші за 0 чи більші за 7
            if (numbers.Max() > Enum.GetValues(typeof(Software)).Cast<int>().Max() || numbers.Min() < Enum.GetValues(typeof(Software)).Cast<int>().Min())
            {
                Console.WriteLine("\nYOU MUST ENTER A NUMBER FROM 0 to 7!\n");

                goto again;
            }

            Console.WriteLine("\nYour favourite software products: ");

            foreach (int number in numbers)
            {
                Console.WriteLine($"#{number}: {(Software)number}");
            }
        }
    }
}