using NUnit.Framework;

namespace RomanNumeralsKataTests
{
    [TestFixture]
    public class ArabicToRomanTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void ArabicToRomanTest()
        {
            const string arabicOne = "1";

            Assert.That(arabicOne, Is.EqualTo("I"));
        }
    }
}
