using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    [TestFixture]
    public class RomanNumeralsTests
    {
        [TestCase(1,"I")]
        [TestCase(4,"IV")]
        [TestCase(5,"V")]
        [TestCase(9,"IX")]
        public void GetRomanNumerals_GivenAnyNumberInCategoryOfUnits_ShouldReturnThatNumberInRomanNumerals(int number, string expected)
        {
            //----------------------------Arrange-------------------------------------
            var romanNumerals = CreateRomanNumerals();

            //----------------------------Act-----------------------------------------
            var actual = romanNumerals.GetRomanNumerals(number);

            //----------------------------Assert--------------------------------------
            Assert.AreEqual(expected, actual);

        }

        [TestCase(10,"X")]
        [TestCase(40,"XL")]
        [TestCase(50,"L")]
        [TestCase(90,"XC")]
        public void GetRomanNumerals_GivenAnyNumberInCategoryOfTens_ShouldReturnThatNumberInRomanNumerals(int number, string expected)
        {
            //----------------------------Arrange-------------------------------------
            var romanNumerals = CreateRomanNumerals();

            //----------------------------Act-----------------------------------------
            var actual = romanNumerals.GetRomanNumerals(number);

            //----------------------------Assert--------------------------------------
            Assert.AreEqual(expected, actual);

        }

        [TestCase(11,"XI")]
        [TestCase(54,"LIV")]
        [TestCase(74,"LXXIV")]
        [TestCase(94,"XCIV")]
        public void GetRomanNumerals_GivenAnyNumberThatIsMixOfTensAndUnits_ShouldReturnThatNumberInRomanNumerals(int number, string expected)
        {
            //----------------------------Arrange-------------------------------------
            var romanNumerals = CreateRomanNumerals();

            //----------------------------Act-----------------------------------------
            var actual = romanNumerals.GetRomanNumerals(number);

            //----------------------------Assert--------------------------------------
            Assert.AreEqual(expected, actual);

        }

        [TestCase(100, "C")]
        [TestCase(400, "CD")]
        [TestCase(500, "D")]
        [TestCase(900, "CM")]
        public void GetRomanNumerals_GivenAnyNumberInCategoryOfHundreds_ShouldReturnThatNumberInRomanNumerals(int number, string expected)
        {
            //----------------------------Arrange-------------------------------------
            var romanNumerals = CreateRomanNumerals();

            //----------------------------Act-----------------------------------------
            var actual = romanNumerals.GetRomanNumerals(number);

            //----------------------------Assert--------------------------------------
            Assert.AreEqual(expected, actual);

        }

        [TestCase(110, "CX")]
        [TestCase(444, "CDXLIV")]
        [TestCase(555, "DLV")]
        [TestCase(999, "CMXCIX")]
        public void GetRomanNumerals_GivenAnyNumberThatIsMixOfHundredsTensAndUnits_ShouldReturnThatNumberInRomanNumerals(int number, string expected)
        {
            //----------------------------Arrange-------------------------------------
            var romanNumerals = CreateRomanNumerals();

            //----------------------------Act-----------------------------------------
            var actual = romanNumerals.GetRomanNumerals(number);

            //----------------------------Assert--------------------------------------
            Assert.AreEqual(expected, actual);

        }

        [TestCase(1000, "M")]
        [TestCase(2000, "MM")]
        public void GetRomanNumerals_GivenAnyNumberInCategoryOfThousands_ShouldReturnThatNumberInRomanNumerals(int number, string expected)
        {
            //----------------------------Arrange-------------------------------------
            var romanNumerals = CreateRomanNumerals();

            //----------------------------Act-----------------------------------------
            var actual = romanNumerals.GetRomanNumerals(number);

            //----------------------------Assert--------------------------------------
            Assert.AreEqual(expected, actual);

        }
        
        [TestCase(1110, "MCX")]
        [TestCase(2444, "MMCDXLIV")]
        [TestCase(1555, "MDLV")]
        [TestCase(2999, "MMCMXCIX")]
        public void GetRomanNumerals_GivenAnyNumberThatIsMixOfThousandsHundredsTensAndUnits_ShouldReturnThatNumberInRomanNumerals(int number, string expected)
        {
            //----------------------------Arrange-------------------------------------
            var romanNumerals = CreateRomanNumerals();

            //----------------------------Act-----------------------------------------
            var actual = romanNumerals.GetRomanNumerals(number);

            //----------------------------Assert--------------------------------------
            Assert.AreEqual(expected, actual);

        }

        [TestCase(1990, "MCMXC")]
        [TestCase(2009, "MMIX")]
        [TestCase(1009, "MIX")]
        [TestCase(2008, "MMVIII")]
        public void GetRomanNumerals_GivenAnyNumberNumberLessThanThreeThousand_ShouldReturnThatNumberInRomanNumerals(int number, string expected)
        {
            //----------------------------Arrange-------------------------------------
            var romanNumerals = CreateRomanNumerals();

            //----------------------------Act-----------------------------------------
            var actual = romanNumerals.GetRomanNumerals(number);

            //----------------------------Assert--------------------------------------
            Assert.AreEqual(expected, actual);

        }

        private static RomanNumerals CreateRomanNumerals()
        {
            return new RomanNumerals();
        }
    }
}
