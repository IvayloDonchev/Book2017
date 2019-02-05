using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch04Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "benjamin";
            const string niceName = "andrea";
            const string sillyName = "ploppy";
            string name;
            WriteLine("What is your name?");
            name = ReadLine();
            switch (name.ToLower())
            {
                case myName:
                    WriteLine("You have the same name as me!");
                    break;
                case niceName:
                    WriteLine("My, what a nice name you have!");
                    break;
                case sillyName:
                    WriteLine("That's a very silly name.");
                    break;
            }
            WriteLine($"Hello {name}!");
            ReadKey();

            Random rnd = new Random();
            int caseSwitch = rnd.Next(1, 4);

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                case 3:
                    Console.WriteLine($"Case {caseSwitch}");
                    break;
                default:
                    Console.WriteLine($"An unexpected value ({caseSwitch})");
                    break;
            }
            ReadKey();

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("The weekend");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("The first day of the work week.");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("The last day of the work week.");
                    break;
                default:
                    Console.WriteLine("The middle of the work week.");
                    break;
            }

            ReadKey();
        }
    }
}
