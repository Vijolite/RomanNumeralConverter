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