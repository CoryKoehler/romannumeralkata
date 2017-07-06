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

        public void ArabicNineToRomanNine()
        {
            var romanNumber = _arabicToRomanConverter.ArabicToRoman(9);

            Assert.That(romanNumber, Is.EqualTo("IX"));
        }

        public void ArabicNineHundredNineityToRomanNineHundredNineity()
        {
            var romanNumber = _arabicToRomanConverter.ArabicToRoman(1990);

            Assert.That(romanNumber, Is.EqualTo("MCMXC"));
        }

        //TODO Bring this to a new test fixture that will handle any case of a roman numeral appearing more than three times in a row
        //[Test]
        //public void ThriceRepeatedRomanNumeral()
        //{
        //    var romanNumber = _arabicToRomanConverter.ArabicToRoman(2499);
        //    Assert.That(romanNumber, Is.EqualTo("MMCDXCIX"));

        //    romanNumber = _arabicToRomanConverter.ArabicToRoman(3949);
        //    Assert.That(romanNumber, Is.EqualTo("MMMCMXLIX"));

        //}
    }
}
