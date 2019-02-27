using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch04Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            do
            {
                Write("Въведете число: ");
                a = ToInt32(ReadLine());
                Write("Въведете число: ");
                b = ToInt32(ReadLine());
            } while ((a>10) && (b>10));
            WriteLine($"a = {a}, b = {b}");

            ReadKey();
        }
    }
}
