namespace RomanNumeralsKata
{
    public class ConversionHandler
    {
        private readonly IArabicToRomanConverter _iArabicToRomanConverter;
        public  ConversionHandler(IArabicToRomanConverter arabicToRomanConverter)
        {
            _iArabicToRomanConverter = arabicToRomanConverter;
        }

        public void HandleArabicToRomanConversion(int arabicNumber)
        {
            _iArabicToRomanConverter.ArabicToRoman(arabicNumber);
        }
    }
}
