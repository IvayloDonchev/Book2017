using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch05Ex02
{
    enum Orientation : byte
    {
        north = 1,
        south = 2,
        east = 3,
        west = 4
    }
    struct Route
    {
        public Orientation direction;
        public double distance;
        public void SetRoute(Orientation o, double d)
        {
            direction = o;
            distance = d;
        }
        public override string ToString()
        {
            return $"Direction: {direction}, distance: {distance}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "This is a test.";
            char[] separator = { ' ' };
            var myWords = myString.Split(separator);
            foreach (string word in myWords)
            {
                WriteLine($"{word}");
            }
            ReadKey();
        }
    }
}
