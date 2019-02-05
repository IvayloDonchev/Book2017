using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch05Ex01
{
    class Program
    {
        enum Orientation : byte
        {
            north = 1,
            south = 2,
            east = 3,
            west = 4
        }
        static void Main(string[] args)
        {
            byte directionByte;
            string directionString;
            Orientation myDirection = Orientation.north;
            WriteLine($"myDirection = {myDirection}");
            directionByte = (byte)myDirection;
            directionString = Convert.ToString(myDirection);
            WriteLine($"byte equivalent = {directionByte}");
            WriteLine($"string equivalent = {directionString}");

            string myString = "north";
            myDirection = (Orientation)Enum.Parse(typeof(Orientation), myString);
            ReadKey();
        }
    }
}
