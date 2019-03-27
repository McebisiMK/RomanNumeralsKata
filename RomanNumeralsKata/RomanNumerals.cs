using System;
using System.Collections.Generic;

namespace RomanNumeralsKata
{
    public class RomanNumerals
    {
        private IRomanNumeralsDataService _romanNumeralsDataService;

        public RomanNumerals() : this(new RomanNumeralsDataService())
        {
        }

        public RomanNumerals(RomanNumeralsDataService romanNumeralsDataService)
        {
            _romanNumeralsDataService = romanNumeralsDataService;
        }

        public string GetRomanNumerals(int number)
        {
            var units = GetUnits(number);
            var tens = GetTens(number, units);
            var hundreds = GetHundreds(number, units, tens);
            var thousands = GetThousands(number, units, tens, hundreds);
            var unitNumeral = _romanNumeralsDataService.GetUnitsRomanNumeral(units);
            var tensNumeral = _romanNumeralsDataService.GetTensRomanNumeral(tens);
            var hundredsNumeral = _romanNumeralsDataService.GetHundredsRomanNumeral(hundreds);
            var thousandsNumeral = _romanNumeralsDataService.GetThousandsRomanNumeral(thousands);

            return $"{thousandsNumeral}{hundredsNumeral}{tensNumeral}{unitNumeral}";
        }

        private static int GetThousands(int number, int units, int tens, int hundreds)
        {
            return ((number - hundreds) - tens) - units;
        }

        private static int GetHundreds(int number, int units, int tens)
        {
            return ((number % 1000) - tens) - units;
        }

        private static int GetTens(int number, int units)
        {
            return ((number % 1000) % 100) - units;
        }

        private static int GetUnits(int number)
        {
            return (((number % 1000) % 100) % 10);
        }
    }
}