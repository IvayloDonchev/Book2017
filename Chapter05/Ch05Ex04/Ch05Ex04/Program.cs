using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch05Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendNames = { "Todd Anthony", "Kevin Holton", "Shane Laigle", null, "" };
            foreach (var friendName in friendNames)
            {
                switch (friendName)
                {
                    case string t when t.StartsWith("T"):
                        WriteLine($"This friends name starts with a 'T': {friendName} and is {t.Length - 1} letters long ");
                        break;
                    case string e when e.Length == 0:
                        WriteLine("There is a string in the array with no value");
                        break;
                    case null:
                        WriteLine("There was a 'null' value in the array");
                        break;
                    case var x:
                        WriteLine($"This is the var pattern of type: {x.GetType().Name}");
                        break;
                }
            }
            Console.WriteLine("\n------------------------------------------------\n\n");
            int sum = 0, total = 0, counter = 0, intValue = 0;
            int?[] myIntArray = new int?[7] { 5, intValue, 9, 10, null, 2, 99 };
            foreach (var integer in myIntArray)
            {
                switch (integer)
                {
                    case 0:
                        WriteLine($"Integer number '{ counter }' has a default value of 0");
                        counter++;
                        break;
                    case int value:
                        sum += value;
                        WriteLine($"Integer number '{ counter }' has a value of {value}");
                        counter++;
                        break;
                    case null:
                        WriteLine($"Integer number '{ counter }' is null");
                        counter++;
                        break;
                    default:
                        break;
                }
            }
            WriteLine($"{total} total integers, {counter} integers with a value other than 0 or null have a sum value of {sum}");


            int[,] mas = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            for(int i=0; i<3; ++i)
            {
                for (int j = 0; j < 4; ++j)
                    Write($"{mas[i, j]}\t");
                WriteLine();
            }
            foreach(var x in mas)
                Console.Write($"{x}, ");
            Console.WriteLine(); Console.WriteLine();

            int[][] jaggedArray = { new int[] { 1, 2, 3 }, new int[] { 4, 5 }, new int[] { 6, 7, 8, 9, 10, 11, 12 } };
            foreach(int[] row in jaggedArray)
            {
                foreach(int x in row)
                    Console.Write($"{x}\t");
                Console.WriteLine();
            }

            ReadKey();
        }
    }
}
