using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    public class RomanNumeralsDataService : IRomanNumeralsDataService
    {
        public string GetUnitsRomanNumeral(int number)
        {
            var unitsRomanNumerals = new Dictionary<int, string>();

            unitsRomanNumerals.Add(0, "");
            unitsRomanNumerals.Add(1, "I");
            unitsRomanNumerals.Add(2, "II");
            unitsRomanNumerals.Add(3, "III");
            unitsRomanNumerals.Add(4, "IV");
            unitsRomanNumerals.Add(5, "V");
            unitsRomanNumerals.Add(6, "VI");
            unitsRomanNumerals.Add(7, "VII");
            unitsRomanNumerals.Add(8, "VIII");
            unitsRomanNumerals.Add(9, "IX");

            return unitsRomanNumerals[number];
        }

        public string GetTensRomanNumeral(int number)
        {
            var tensRomanNumerals = new Dictionary<int, string>();

            tensRomanNumerals.Add(0, "");
            tensRomanNumerals.Add(10, "X");
            tensRomanNumerals.Add(20, "XX");
            tensRomanNumerals.Add(30, "XXX");
            tensRomanNumerals.Add(40, "XL");
            tensRomanNumerals.Add(50, "L");
            tensRomanNumerals.Add(60, "LX");
            tensRomanNumerals.Add(70, "LXX");
            tensRomanNumerals.Add(80, "LXXX");
            tensRomanNumerals.Add(90, "XC");

            return tensRomanNumerals[number];
        }

        public string GetHundredsRomanNumeral(int number)
        {
            var hundredsRomanNumerals = new Dictionary<int, string>();

            hundredsRomanNumerals.Add(0, "");
            hundredsRomanNumerals.Add(100, "C");
            hundredsRomanNumerals.Add(200, "CC");
            hundredsRomanNumerals.Add(300, "CCC");
            hundredsRomanNumerals.Add(400, "CD");
            hundredsRomanNumerals.Add(500, "D");
            hundredsRomanNumerals.Add(600, "DC");
            hundredsRomanNumerals.Add(700, "DCC");
            hundredsRomanNumerals.Add(800, "DCCC");
            hundredsRomanNumerals.Add(900, "CM");

            return hundredsRomanNumerals[number];
        }

        public string GetThousandsRomanNumeral(int number)
        {
            var thousandsRomanNumerals = new Dictionary<int, string>();

            thousandsRomanNumerals.Add(0, "");
            thousandsRomanNumerals.Add(1000, "M");
            thousandsRomanNumerals.Add(2000, "MM");

            return thousandsRomanNumerals[number];
        }
    }
}
