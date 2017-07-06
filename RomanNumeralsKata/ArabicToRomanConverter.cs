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

            while (arabicNumber > 0)
            {
                for (var i = arabicNumbers.Count() - 1; i >= 0; i--)
                    if (arabicNumber / arabicNumbers[i] >= 1)
                    {
                        arabicNumber -= arabicNumbers[i];
                        builder.Append(romanNumerals[i]);
                        break;
                    }
            }
            return builder.ToString();
        }
    }
}