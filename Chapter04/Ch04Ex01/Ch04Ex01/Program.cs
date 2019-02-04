using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch04Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            //ushort a = 0b_1101_0010_1010;
            //ushort b = 0b_1011_0000_1111;
            //ushort c = (ushort) (a & b);
            //Console.WriteLine(Convert.ToString(c,2));  //основа само 2, 8, 10 или 16 
            //Console.WriteLine(Convert.ToString(~a, 2));

            //WriteLine("Enter an integer:");
            //int myInt = Convert.ToInt32(ReadLine());
            //bool isLessThan10 = myInt < 10;
            //bool isBetween0And5 = (0 <= myInt) && (myInt <= 5);
            //WriteLine($"Integer less than 10? {isLessThan10}");
            //WriteLine($"Integer between 0 and 5? {isBetween0And5}");
            //WriteLine($"Exactly one of the above is true? {isLessThan10 ^ isBetween0And5}");


            int a = 5, b = 6;
            (a > b ? ref a : ref b) = 10;
            Console.WriteLine($"a = {a}, b = {b}");
            
            Console.ReadKey();

        }
    }
}
