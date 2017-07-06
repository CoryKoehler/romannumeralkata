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
        public void ArabicOneToRomanOne()
        {
            var romanNumeral = _arabicToRomanConverter.ArabicToRoman(1);

            Assert.That(romanNumeral, Is.EqualTo("I"));
        }

        [Test]
        public void ArabicTwoToRomanTwo()
        {
            var romanNumber = _arabicToRomanConverter.ArabicToRoman(2);

            Assert.That(romanNumber, Is.EqualTo("II"));
        }

        [Test]
        public void ArabicThreeToRomanThree()
        {
            var romanNumber = _arabicToRomanConverter.ArabicToRoman(3);

            Assert.That(romanNumber, Is.EqualTo("III"));
        }

        [Test]
        public void ArabicFourToRomanFour()
        {
            var romanNumber = _arabicToRomanConverter.ArabicToRoman(4);

            Assert.That(romanNumber, Is.EqualTo("IV"));
        }

        [Test]
        public void ArabicFiveToRomanFive()
        {
            var romanNumber = _arabicToRomanConverter.ArabicToRoman(5);

            Assert.That(romanNumber, Is.EqualTo("V"));
        }
    }
}
