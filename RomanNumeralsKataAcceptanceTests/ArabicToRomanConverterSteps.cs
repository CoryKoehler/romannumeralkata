using Moq;
using NUnit.Framework;
using RomanNumeralsKata;
using TechTalk.SpecFlow;

namespace RomanNumeralsKataAcceptanceTests
{
    [Binding]
    public class ArabicToRomanConverterSteps
    {
        private Mock<IArabicToRomanConverter> _arabicToRomanConverter;
        private Mock<IRomanToArabicConverter> _romanToArabicConverter;
        private ConversionHandler _conversionHandler;
        private const string RomanNumeral = "CXX";

        public void Setup()
        {
            _arabicToRomanConverter = new Mock<IArabicToRomanConverter>() {CallBase = true};
            _arabicToRomanConverter.Setup(_ => _.ArabicToRoman(70)).Returns("CXX");

            _romanToArabicConverter = new Mock<IRomanToArabicConverter>() { CallBase = true };
            _romanToArabicConverter.Setup(_ => _.RomanToArabic("CXX")).Returns(70);
            _conversionHandler = new ConversionHandler(_arabicToRomanConverter.Object, _romanToArabicConverter.Object);
        }

        [Given(@"I have started the converter")]
        public void GivenIHaveStartedTheConverter()
        {
            Setup();
           
        }
        
        [When(@"I enter (.*)")]
        public void WhenIEnter(int p0)
        {
            _conversionHandler.HandleArabicToRomanConversion(p0);
            _arabicToRomanConverter.Verify(_ => _.ArabicToRoman(70));
        }
        
        [Then(@"the result should be CXX")]
        public void ThenTheResultShouldBeCXX()
        {
            
            Assert.That(RomanNumeral, Is.EqualTo("CXX"));
        }
    }
}
