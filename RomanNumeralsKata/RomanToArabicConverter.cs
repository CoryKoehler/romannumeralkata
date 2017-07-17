using System;
using System.Linq;

namespace RomanNumeralsKata
{
    public class RomanToArabicConverter : IRomanToArabicConverter
    {
        public int RomanToArabic(string romanNumeral)
        {
            var arabicNumbers = Enum.GetValues(typeof(RomanNumeralEnum)).Cast<int>().ToArray();
            var romanNumerals = Enum.GetNames(typeof(RomanNumeralEnum)).Select(x => x.ToString()).ToArray();

            return 1;
        }
    }
}
