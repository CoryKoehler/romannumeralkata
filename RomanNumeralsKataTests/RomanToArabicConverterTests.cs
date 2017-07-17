using NUnit.Framework;
using RomanNumeralsKata;

namespace RomanNumeralsKataTests
{
    [TestFixture]
    public class RomanToArabicConverterTests
    {

        private IRomanToArabicConverter _romanToArabicConverter;

        [SetUp]
        public void Setup()
        {
            _romanToArabicConverter = new RomanToArabicConverter();
        }

        [Test]
        public void ArabicOneToRomanOne()
        {
            var arabicNumber = _romanToArabicConverter.RomanToArabic("I");

            Assert.That(arabicNumber, Is.EqualTo(1));
        }

        [Test]
        public void ArabicTwoToRomanTwo()
        {
            var arabicNumber = _romanToArabicConverter.RomanToArabic("II");

            Assert.That(arabicNumber, Is.EqualTo(2));
        }

        [Test]
        public void ArabicThreeToRomanThree()
        {
            var arabicNumber = _romanToArabicConverter.RomanToArabic("III");

            Assert.That(arabicNumber, Is.EqualTo(3));
        }

        [Test]
        public void ArabicFourToRomanFour()
        {
            var arabicNumber = _romanToArabicConverter.RomanToArabic("IV");

            Assert.That(arabicNumber, Is.EqualTo(4));
        }

        [Test]
        public void ArabicFiveToRomanFive()
        {
            var arabicNumber = _romanToArabicConverter.RomanToArabic("V");

            Assert.That(arabicNumber, Is.EqualTo(5));
        }

        [Test]
        public void ArabicNineToRomanNine()
        {
            var arabicNumber = _romanToArabicConverter.RomanToArabic("IX");

            Assert.That(arabicNumber, Is.EqualTo(9));
        }

        [Test]
        public void ArabicNineHundredNineityToRomanNineHundredNineity()
        {
            var arabicNumber = _romanToArabicConverter.RomanToArabic("MCMXC");

            Assert.That(arabicNumber, Is.EqualTo(1990));
        }
    }
}
