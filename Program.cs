using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Olawale!");
            List<string> str = new List<string>();
            string[] astr = { "Ola", "ola", "Tango" };
            str.AddRange(astr);
            Console.WriteLine(str[0].ToLower().Equals(str[1].ToLower()));
            

            string numberToWords=SurroundingClass.changeToWords("20050000");
            Console.WriteLine(numberToWords);

            Console.ReadKey();
        }
    }
}
