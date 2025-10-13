using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SorteadorCsharp
{
    public class Menus
    {
        public static void Menu()
        {
            // Calculate spaces for centering the title
            string bars = new string('=', 37);
            string title = "SORTER";
            int width = bars.Length;
            int spaces = (width - title.Length) / 2;

            // Display the menu with a slight delay for better user experience
            System.Threading.Thread.Sleep(400);
            System.Console.WriteLine(bars);

            System.Threading.Thread.Sleep(400);
            Console.WriteLine(new string(' ', spaces) + title);

            System.Threading.Thread.Sleep(400);
            System.Console.WriteLine(bars);

            System.Threading.Thread.Sleep(400);
            Console.WriteLine("\n1. Sort number");

            System.Threading.Thread.Sleep(400);
            Console.WriteLine("0. Exit");

            System.Threading.Thread.Sleep(400);
            Console.Write("\nChoose an option: ");
        }

        public static void StartChoice()
        {
            Console.Clear();

            Console.Write("Initial Number: ");
            int initialNumber = int.Parse(Console.ReadLine());

            Console.Write("Final Number: ");
            int finalNumber = int.Parse(Console.ReadLine());

            Sorter values = new Sorter(initialNumber, finalNumber);
            values.SortNumber();

            Console.Clear();
            Console.Write($"Result: {values.Result}\n");

            RepeatSort();
        }

        public static void AlternateSort()
        {
            Console.Clear();

            Console.Write("Initial Number: ");
            int initialNumber = int.Parse(Console.ReadLine());

            Console.Write("Final Number: ");
            int finalNumber = int.Parse(Console.ReadLine());

            Sorter values = new Sorter(initialNumber, finalNumber);
            values.SortDifferentNumber();

            Console.Clear();
            Console.Write($"Result: {values.Result}\n");

            RepeatSort();
        }

        public static void RepeatSort()
        {
            Console.Write($"\nWould you like to sort another number? (y/n): ");
            char response = char.Parse(Console.ReadLine().ToLower());

            // Same thing as Program.cs
            while (response != 'y' && response != 'n')
            {
                Console.Clear();
                Console.Write("Invalid option!");
                System.Threading.Thread.Sleep(2000);

                Console.Clear();
                Console.Write("Would you like to sort another number? (y/n): ");
                response = char.Parse(Console.ReadLine().ToLower());
            }

            if (response == 'y')
            {
                RepeatResult();
            }
            else if (response == 'n')
            {
                Exit();
            }
        }

        public static void RepeatResult()
        {
            Sorter values;

            Console.Write($"\nRepeat the result in the new draw?(y/n): ");
            char response = char.Parse(Console.ReadLine().ToLower());

            // Same thing as above
            while (response != 'y' && response != 'n')
            {
                Console.Clear();

                Console.Write("Invalid option!");
                System.Threading.Thread.Sleep(500);

                Console.Clear();

                Console.Write("Repeat the result in the new draw?(y/n): ");
                response = char.Parse(Console.ReadLine().ToLower());
            }

            if (response == 'y')
            {
                StartChoice();
            }
            else if (response == 'n')
            {
                AlternateSort();
            }
        }

        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Thank you for using the sorter!");
            System.Threading.Thread.Sleep(1000);

            // Simulates a loading effect before exiting by printing dots with delays
            Console.Write("Exiting");

            System.Threading.Thread.Sleep(750);
            Console.Write(".");

            System.Threading.Thread.Sleep(750);
            Console.Write(".");

            System.Threading.Thread.Sleep(750);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);

            Environment.Exit(0); // Ends the program
        }
    }
}