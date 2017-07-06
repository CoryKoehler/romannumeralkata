using System;
using System.CodeDom;
using System.Linq;
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
            int[] arabicNumbers = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            var romanNumerals = Enum.GetValues(typeof(RomanNumeralEnum)).Cast<int>().Select(x => x.ToString()).ToArray();

            var builder = new StringBuilder();
            var remaining = arabicNumber;

            for (var i = 0; i < arabicNumbers.Length; i++)
            {
                remaining = AppendRomanNumerals(remaining, arabicNumbers[i], romanNumerals[i], builder);
            }

            while (remaining >= 1)
            {
                builder.Append("I");
                remaining -= 1;
            }

            return builder.ToString();
        }

        private static int AppendRomanNumerals(int arabicNumber, int value, string romanNumeral, StringBuilder builder)
        {
            var result = arabicNumber;
            while (result >= value)
            {
                builder.Append(romanNumeral);
                result -= value;
            }
            return result;
        }
    }
}