using NUnit.Framework;

namespace RomanNumeralsKata
{
    [TestFixture]
    public class RomanNumeralsTests
    {
        [TestCase(1, "I")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(9, "IX")]
        public void GetRomanNumerals_GivenNumberFromOneToNine_ShouldReturnCorrespondingRomanNumeral(int number, string expected)
        {
            //----------------Arrange--------------------------------
            var romanNumeralsService = CreateRomanNumeralsService();

            //----------------Arrange--------------------------------
            var actual = romanNumeralsService.GetRomanNumeral(number);

            //----------------Arrange--------------------------------
            Assert.AreEqual(expected, actual);

        }

        [TestCase(10, "X")]
        [TestCase(40, "XL")]
        [TestCase(50, "L")]
        [TestCase(60, "LX")]
        [TestCase(90, "XC")]
        public void GetRomanNumerals_GivenNumberFromTenToNinety_ShouldReturnCorrespondingRomanNumeral(int number, string expected)
        {
            //----------------Arrange--------------------------------
            var romanNumeralsService = CreateRomanNumeralsService();

            //----------------Arrange--------------------------------
            var actual = romanNumeralsService.GetRomanNumeral(number);

            //----------------Arrange--------------------------------
            Assert.AreEqual(expected, actual);

        }

        [TestCase(100, "C")]
        [TestCase(400, "CD")]
        [TestCase(500, "D")]
        [TestCase(600, "DC")]
        [TestCase(900, "CM")]
        public void GetRomanNumerals_GivenNumberFromHundredToNineHundred_ShouldReturnCorrespondingRomanNumeral(int number, string expected)
        {
            //----------------Arrange--------------------------------
            var romanNumeralsService = CreateRomanNumeralsService();

            //----------------Arrange--------------------------------
            var actual = romanNumeralsService.GetRomanNumeral(number);

            //----------------Arrange--------------------------------
            Assert.AreEqual(expected, actual);

        }

        [TestCase(10, "X")]
        [TestCase(14, "XIV")]
        [TestCase(15, "XV")]
        [TestCase(19, "XIX")]
        public void GetRomanNumerals_GivenNumberFromTenToNineteen_ShouldReturnCorrespondingRomanNumeral(int number, string expected)
        {
            //----------------Arrange--------------------------------
            var romanNumeralsService = CreateRomanNumeralsService();

            //----------------Arrange--------------------------------
            var actual = romanNumeralsService.GetRomanNumeral(number);

            //----------------Arrange--------------------------------
            Assert.AreEqual(expected, actual);

        }

        private static RomanNumeralsService CreateRomanNumeralsService()
        {
            return new RomanNumeralsService();
        }
    }
}
