using System;
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
            var builder = new StringBuilder();
            var remaining = arabicNumber;
            remaining = AppendRomanNumerals(remaining, 9, NumberNumeralEnum.IX, builder);
            remaining = AppendRomanNumerals(remaining, 5, NumberNumeralEnum.V, builder);
            remaining = AppendRomanNumerals(remaining, 4, NumberNumeralEnum.IV, builder);
            for (var i = 0; i < remaining; i++)
            {
                builder.Append("I");
            }
            return builder.ToString();
        }

        private static int AppendRomanNumerals(int arabicNumber, int value, NumberNumeralEnum romanNumeral, StringBuilder builder)
        {
            var result = arabicNumber;
            if (result < value) return result;
            builder.Append(romanNumeral);
            result -= value;
            return result;
        }
    }
}