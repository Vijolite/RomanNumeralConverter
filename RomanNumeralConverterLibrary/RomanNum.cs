namespace RomanNumeralConverterLibrary
{
    public class RomanNum
    {
        private static string[] table = new string[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };

        public static bool IsRomanNumeral(string romanValue)
        {
            return (Array.IndexOf(table, romanValue) != -1);
        }

        private string romanValue;
        public string RomanValue 
        { 
            get { return romanValue; }
            set 
            { 
                if (IsRomanNumeral(value)) romanValue = value; 
                else throw new Exception("It is not a Roman numeral (or it is greater than X)");
            } 
        }

        public RomanNum(string romanValue)
        {
            RomanValue = romanValue;
        }
        public int ConvertIntoInt()
        {
            int position = Array.IndexOf(table, RomanValue);
            return position + 1;
        }

    }
}