using Moq;
using NUnit.Framework;
using RomanNumeralsKata;

namespace RomanNumeralsKataTests
{
    [TestFixture]
    public class ConversionHandlerTests
    {
        private ConversionHandler _conversionHandler;
        private Mock<IArabicToRomanConverter> _arabicToRomanConverter;
        private Mock<IRomanToArabicConverter> _romanToArabicConverter;

        [SetUp]
        public void Setup()
        {
            _arabicToRomanConverter = new Mock<IArabicToRomanConverter>();
            _arabicToRomanConverter.Setup(_ => _.ArabicToRoman(4));
            _romanToArabicConverter = new Mock<IRomanToArabicConverter>();
            _romanToArabicConverter.Setup(_ => _.RomanToArabic("IV"));

            _conversionHandler = new ConversionHandler(_arabicToRomanConverter.Object, _romanToArabicConverter.Object);
        }

        [Test]
        public void CanConvertRomanNumeralToArabicNumber()
        {
            _conversionHandler.HandleArabicToRomanConversion(4);
            _arabicToRomanConverter.Verify(_ => _.ArabicToRoman(4), Times.AtLeastOnce);
        }

        [Test]
        public void CanConvertArabicNumberToRomanNumeral()
        {
            _conversionHandler.HandleRomanToArabicConversion("IV");
            _romanToArabicConverter.Verify(_ => _.RomanToArabic("IV"), Times.AtLeastOnce);
        }
    }
}
