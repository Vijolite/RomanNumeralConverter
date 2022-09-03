using System;
using RomanNumeralConverterLibrary;

namespace RomanNumeralsConverter
{
    class Program
    {
        public static void Main()

        {
            Console.WriteLine("Please enter a Roman Numeral");
            var romanNumeral = new RomanNum(Console.ReadLine());
            Console.WriteLine($"You converted the Roman Numeral {romanNumeral.RomanValue} to the number {romanNumeral.ConvertIntoInt()}");
        }
    }
}