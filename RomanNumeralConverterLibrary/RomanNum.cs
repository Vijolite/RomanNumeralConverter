using System.Text.RegularExpressions;

namespace RomanNumeralConverterLibrary
{
    public class RomanNum
    {
        private static Dictionary<char, int> romanTranslation = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        public static bool IsRomanNumeral(string romanValue) // should be more complicted not just checking if it contains from specific letters
        {
            if (romanValue.Length == 0) return false;
            else 
            {
                foreach (char letter in romanValue)
                {
                    if (!romanTranslation.ContainsKey(letter)) return false;
                }
                return true;
                //string strRegex = @"(^M{ 0,3} (CM | CD | D ? C{ 0,3})(XC | XL | L ? X{ 0,3})(IX | IV | V ? I{ 0,3})$)";
                //Regex re = new Regex(strRegex);
                //return re.IsMatch(romanValue);

            }
        }

        private string romanValue;
        public string RomanValue 
        { 
            get { return romanValue; }
            set 
            { 
                if (IsRomanNumeral(value)) romanValue = value; 
                else throw new Exception("It is not a Roman numeral");
            } 
        }

        public RomanNum(string romanValue)
        {
            RomanValue = romanValue;
        }
        public int ConvertIntoInt()
        {
            int result = 0;
            for (int i = this.RomanValue.Length-1; i>=0; i--)
            {
                if (i == this.RomanValue.Length - 1) // the 1st letter from the right
                    result += romanTranslation[this.RomanValue[i]];
                else
                    if (romanTranslation[this.RomanValue[i]]< romanTranslation[this.RomanValue[i+1]])
                        result -= romanTranslation[this.RomanValue[i]];
                    else
                        result += romanTranslation[this.RomanValue[i]];
            }
            return result;
        }

    }
}