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
            var romanNumeral = _arabicToRomanConverter.ArabicToRoman(2);

            Assert.That(romanNumeral, Is.EqualTo("II"));
        }

        [Test]
        public void ArabicThreeToRomanThree()
        {
            var romanNumeral = _arabicToRomanConverter.ArabicToRoman(3);

            Assert.That(romanNumeral, Is.EqualTo("III"));
        }

        [Test]
        public void ArabicFourToRomanFour()
        {
            var romanNumeral = _arabicToRomanConverter.ArabicToRoman(4);

            Assert.That(romanNumeral, Is.EqualTo("IV"));
        }

        [Test]
        public void ArabicFiveToRomanFive()
        {
            var romanNumeral = _arabicToRomanConverter.ArabicToRoman(5);

            Assert.That(romanNumeral, Is.EqualTo("V"));
        }

        [Test]
        public void ArabicNineToRomanNine()
        {
            var romanNumeral = _arabicToRomanConverter.ArabicToRoman(9);

            Assert.That(romanNumeral, Is.EqualTo("IX"));
        }

        [Test]
        public void ArabicNineHundredNineityToRomanNineHundredNineity()
        {
            var romanNumeral = _arabicToRomanConverter.ArabicToRoman(1990);

            Assert.That(romanNumeral, Is.EqualTo("MCMXC"));
        }

        //TODO Bring this to a new test fixture that will handle any case of a roman numeral appearing more than three times in a row
        //[Test]
        //public void ThriceRepeatedRomanNumeral()
        //{
        //    var romanNumeral = _arabicToRomanConverter.ArabicToRoman(2499);
        //    Assert.That(romanNumeral, Is.EqualTo("MMCDXCIX"));

        //    romanNumeral = _arabicToRomanConverter.ArabicToRoman(3949);
        //    Assert.That(romanNumeral, Is.EqualTo("MMMCMXLIX"));

        //}
    }
}
