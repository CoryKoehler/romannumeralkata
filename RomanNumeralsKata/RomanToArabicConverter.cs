using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsKata
{
    public class RomanToArabicConverter : IRomanToArabicConverter
    {
        private static readonly Dictionary<char, int> RomanMap = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public int RomanToArabic(string romanNumeral)
        {
            var arabicNumber = 0;
            for (var i = 0; i < romanNumeral.Length; i++)
            {
                if (i + 1 < romanNumeral.Length && RomanMap[romanNumeral[i]] < RomanMap[romanNumeral[i + 1]])
                {
                    arabicNumber -= RomanMap[romanNumeral[i]];
                }
                else
                {
                    arabicNumber += RomanMap[romanNumeral[i]];
                }
            }
            return arabicNumber;
        }
    }
}
