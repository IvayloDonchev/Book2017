using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger;
            string myString;
            myInteger = 17;
            myString = "\"myInteger\" is";
            Console.WriteLine($"{myString} {myInteger}");

            myString = "This string has a\nline break.";
            Console.WriteLine($"{myString} {myInteger}");

            int[] binaryPhases = { 0b00110001, 0b01100010, 0b11000100, 0b1000100 };
            int[] hexPhases = { 0x31, 0x62, 0xC4, 0x89 };
                    
            int[] numbers = { 0b0010_0000, 0b0100_0000, 0b1000_0000 };

            myString = @"It's a verbatim string
placed in two lines";
            Console.WriteLine(myString);


            int var1, var2 = 5, var3 = 6;
            var1 = var2++ * --var3;
            Console.WriteLine(var1);

            Console.ReadKey();
        }
    }
}
