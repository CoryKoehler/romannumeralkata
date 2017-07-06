using System;
using System.CodeDom;
using System.Linq;
using System.Net.Sockets;
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
            var arabicNumbers = Enum.GetValues(typeof(RomanNumeralEnum)).Cast<int>().ToArray();
            var romanNumerals = Enum.GetNames(typeof(RomanNumeralEnum)).Select(x => x.ToString()).ToArray();

            var builder = new StringBuilder();
            var remaining = arabicNumber;

            for (var i = 0; i < arabicNumbers.Length; i++)
            {
                remaining = AppendRomanNumerals(remaining, arabicNumbers[i], romanNumerals[i], builder);
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