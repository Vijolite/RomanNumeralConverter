namespace RomanNumeralConverterLibrary
{
    public class RomanNum
    {
        private static string[] table = new string[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };

        private static Dictionary<char, int> romanTranslation = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100}
        };
        public static bool IsRomanNumeral(string romanValue)
        {
            if (romanValue.Length == 0) return false;
            else 
            {
                foreach (char letter in romanValue)
                {
                    if (!romanTranslation.ContainsKey(letter)) return false;
                }
                return true;
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
            for (int i = this.romanValue.Length-1; i>=0; i--)
            {
                if (i == this.romanValue.Length - 1) // the 1st letter from the right
                    result += romanTranslation[this.romanValue[i]];
                else
                    if (romanTranslation[this.romanValue[i]]< romanTranslation[this.romanValue[i+1]])
                        result -= romanTranslation[this.romanValue[i]];
                    else
                        result += romanTranslation[this.romanValue[i]];
            }
            return result;
        }

    }
}