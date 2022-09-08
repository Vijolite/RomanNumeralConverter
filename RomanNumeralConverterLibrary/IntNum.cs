using System.Text.RegularExpressions;
using System;

namespace RomanNumeralConverterLibrary
{
    public class IntNum
    {

        private static string[] thousands = new string[]  { "", "M", "MM", "MMM" };
        private static string[] hundrets = new string[] { "",  "C",  "CC",  "CCC",  "CD", "D", "DC", "DCC", "DCCC", "CM" };
        private static string[] tens = new string[] { "",  "X",  "XX",  "XXX",  "XL","L", "LX", "LXX", "LXXX", "XC" };
        private static string[] ones = new string[] { "",  "I",  "II",  "III",  "IV", "V", "VI", "VII", "VIII", "IX" };
        public int Value { get; set; }

        public IntNum(int value)
        {
            Value = value;
        }
        public string ConvertIntoRoman()
        {
            string thousandsRoman = thousands[Value / 1000];
            return thousandsRoman;
        }

    }
}