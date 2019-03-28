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
        public void GetRomanNumeral_GivenNumberFromUnitsCategory_ShouldReturnCorrespondingRomanNumeral(int number, string expected)
        {
            //----------------Arrange--------------------------------
            var romanNumeralsService = CreateRomanNumeralsService();

            //----------------Act------------------------------------
            var actual = romanNumeralsService.GetRomanNumeral(number);

            //----------------Assert---------------------------------
            Assert.AreEqual(expected, actual);

        }

        [TestCase(10, "X")]
        [TestCase(40, "XL")]
        [TestCase(50, "L")]
        [TestCase(60, "LX")]
        [TestCase(90, "XC")]
        public void GetRomanNumeral_GivenNumberFromTensCategory_ShouldReturnCorrespondingRomanNumeral(int number, string expected)
        {
            //----------------Arrange--------------------------------
            var romanNumeralsService = CreateRomanNumeralsService();

            //----------------Act------------------------------------
            var actual = romanNumeralsService.GetRomanNumeral(number);

            //----------------Assert---------------------------------
            Assert.AreEqual(expected, actual);

        }

        [TestCase(100, "C")]
        [TestCase(400, "CD")]
        [TestCase(500, "D")]
        [TestCase(600, "DC")]
        [TestCase(900, "CM")]
        public void GetRomanNumeral_GivenNumberFromHundredsCategory_ShouldReturnCorrespondingRomanNumeral(int number, string expected)
        {
            //----------------Arrange--------------------------------
            var romanNumeralsService = CreateRomanNumeralsService();

            //----------------Act------------------------------------
            var actual = romanNumeralsService.GetRomanNumeral(number);

            //----------------Assert---------------------------------
            Assert.AreEqual(expected, actual);

        }

        [TestCase(1000, "M")]
        [TestCase(2000, "MM")]
        [TestCase(3000, "MMM")]
        public void GetRomanNumeral_GivenNumberFromOneThousandsCategory_ShouldReturnCorrespondingRomanNumeral(int number, string expected)
        {
            //----------------Arrange--------------------------------
            var romanNumeralsService = CreateRomanNumeralsService();

            //----------------Act------------------------------------
            var actual = romanNumeralsService.GetRomanNumeral(number);

            //----------------Assert----------------------------------
            Assert.AreEqual(expected, actual);

        }

        [TestCase(11, "XI")]
        [TestCase(54, "LIV")]
        [TestCase(99, "XCIX")]
        [TestCase(16, "XVI")]
        [TestCase(49, "XLIX")]
        public void GetRomanNumeral_GivenNumberThatIsACombinationOfTensAndUnits_ShouldReturnCorrespondingRomanNumeral(int number, string expected)
        {
            //-----------------Arrange--------------------------------
            var romanNumeralsService = CreateRomanNumeralsService();

            //-----------------Act------------------------------------
            var actual = romanNumeralsService.GetRomanNumeral(number);

            //----------------Assert----------------------------------
            Assert.AreEqual(expected, actual);

        }

        [TestCase(111, "CXI")]
        [TestCase(454, "CDLIV")]
        [TestCase(555, "DLV")]
        [TestCase(694, "DCXCIV")]
        [TestCase(966, "CMLXVI")]
        public void GetRomanNumeral_GivenNumberThatIsACombinationOfHundredsTensAndUnits_ShouldReturnCorrespondingRomanNumeral(int number, string expected)
        {
            //-------------------Arrange-------------------------------
            var romanNumeralsService = CreateRomanNumeralsService();

            //-------------------Act-----------------------------------
            var actual = romanNumeralsService.GetRomanNumeral(number);

            //-------------------Assert--------------------------------
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3111, "MMMCXI")]
        [TestCase(2454, "MMCDLIV")]
        [TestCase(3555, "MMMDLV")]
        [TestCase(1694, "MDCXCIV")]
        [TestCase(3966, "MMMCMLXVI")]
        public void GetRomanNumeral_GivenNumberThatIsACombinationOfThousandsHundredsTensAndUnits_ShouldReturnCorrespondingRomanNumeral(int number, string expected)
        {
            //-------------------Arrange-------------------------------
            var romanNumeralsService = CreateRomanNumeralsService();

            //-------------------Act-----------------------------------
            var actual = romanNumeralsService.GetRomanNumeral(number);

            //-------------------Assert--------------------------------
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0,"")]
        [TestCase(-5,"")]
        [TestCase(4000,"")]
        public void GetRomanNumeral_GivenInvalidNumber_ShouldReturnEmptyString(int number, string expected)
        {
            //-------------------Arrange-------------------------------
            var romanNumeralsService = CreateRomanNumeralsService();

            //-------------------Act-----------------------------------
            var actual = romanNumeralsService.GetRomanNumeral(number);
            //-------------------Assert--------------------------------
            Assert.AreEqual(expected, actual);
        }

        private static RomanNumeralsService CreateRomanNumeralsService()
        {
            return new RomanNumeralsService();
        }
    }
}
