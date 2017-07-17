namespace RomanNumeralsKata
{
    public class ConversionHandler
    {
        private readonly IArabicToRomanConverter _arabicToRomanConverter;
        private readonly IRomanToArabicConverter _romanToArabicConverter;
        public  ConversionHandler(IArabicToRomanConverter arabicToRomanConverter,
            IRomanToArabicConverter romanToArabicConverter)
        {
            _arabicToRomanConverter = arabicToRomanConverter;
            _romanToArabicConverter = romanToArabicConverter;
        }

        public void HandleArabicToRomanConversion(int arabicNumber)
        {
            _arabicToRomanConverter.ArabicToRoman(arabicNumber);
        }

        public void HandleRomanToArabicConversion(string romanNumeral)
        {
            _romanToArabicConverter.RomanToArabic(romanNumeral);
        }
    }
}
