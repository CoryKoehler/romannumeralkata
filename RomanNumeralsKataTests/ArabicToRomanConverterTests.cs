using NUnit.Framework;
using RomanNumeralsKata;

namespace RomanNumeralsKataTests
{
    [TestFixture]
    public class ArabicToRomanConverterTests
    {
        private IArabicToRomanConverter _arabicToRomanConverter;

        [SetUp]
        public void Setup()
        {
           _arabicToRomanConverter = new ArabicToRomanConverter();
        }

        [Test]
        public void ArabicToRomanTest()
        {
            var romanNumber = _arabicToRomanConverter.ArabicToRoman(1);

            Assert.That(romanNumber, Is.EqualTo("I"));
        }
    }
}
