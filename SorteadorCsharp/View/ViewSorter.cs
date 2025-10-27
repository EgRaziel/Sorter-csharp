using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SorteadorCsharp.Controller;

namespace SorteadorCsharp.View
{
    public class ViewSorter
    {
        public static void Menu()
        {
            System.Threading.Thread.Sleep(400);
            Console.WriteLine("+-------------------------------------+");
            System.Threading.Thread.Sleep(400);
            Console.WriteLine("+               SORTER         v1.3.2 +");
            System.Threading.Thread.Sleep(400);
            Console.WriteLine("+-------------------------------------+");


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
            int initialNumber = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Final Number: ");
            int finalNumber = int.Parse(Console.ReadLine() ?? "0");

            Console.Clear();
            Console.Write($"Result: {ControllerSorter.SortNumber(initialNumber, finalNumber)}\n");

            RepeatSort();
        }

        public static void AlternateSort()
        {
            Console.Clear();

            Console.Write("Initial Number: ");
            int initialNumber = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Final Number: ");
            int finalNumber = int.Parse(Console.ReadLine() ?? "0");

            Console.Clear();
            Console.Write($"Result: {ControllerSorter.SortDifferentNumber(initialNumber, finalNumber)}\n");

            RepeatSort();
        }

        public static void RepeatSort()
        {
            Console.Write($"\nWould you like to sort another number? (y/n): ");
            string response = (Console.ReadLine() ?? "n").ToLower(); // Prevents exception when uppercase input is given

            // Same thing as Program.cs
            while (response != "y" && response != "n")
            {
                Console.Clear();
                Console.Write("Invalid option!");
                System.Threading.Thread.Sleep(2000);

                Console.Clear();
                Console.Write("Would you like to sort another number? (y/n): ");
                response = (Console.ReadLine() ?? "n").ToLower();
            }

            if (response == "y")
            {
                RepeatResult();
            }
            else if (response == "n")
            {
                Exit();
            }
        }

        public static void RepeatResult()
        {
            Console.Write($"\nRepeat the result in the new sort? (y/n): ");
            string response = (Console.ReadLine() ?? "n").ToLower();

            while (response != "y" && response != "n")
            {
                Console.Clear();

                Console.Write("Invalid option!");
                System.Threading.Thread.Sleep(500);

                Console.Clear();

                Console.Write("Repeat the result in the new sort? (y/n): ");
                response = (Console.ReadLine() ?? "n").ToLower();
            }

            if (response == "y")
            {
                StartChoice();
            }
            else if (response == "n")
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