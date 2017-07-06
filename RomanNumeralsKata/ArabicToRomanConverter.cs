using System.Text;

namespace RomanNumeralsKata
{
    public class ArabicToRomanConverter : IArabicToRomanConverter
    {
        public ArabicToRomanConverter()
        {
            //constructor for later use if necessary
        }

        public string ArabicToRoman(int arabicNumber)
        {
            var result = new StringBuilder();
            switch (arabicNumber)
            {
                case 5:
                    result.Append(NumberNumeralEnum.V);
                    break;
                case 4:
                    result.Append(NumberNumeralEnum.IV);
                    break;
                default:
                    for (var i = 0; i < arabicNumber; i++)
                    {
                        result.Append("I");
                    }
                    break;
            }
            return result.ToString();
        }
    }
}