using System;

namespace RomanNumeralsKata
{
    public class RomanNumeralsService
    {
        private IRomanNumeralsRepository romanNumeralsRepository;

        //public RomanNumeralsService() : this(new RomanNumeralsRepository())
        //{

        //}

        public RomanNumeralsService(IRomanNumeralsRepository romanNumeralsRepository)
        {
            this.romanNumeralsRepository = romanNumeralsRepository;
        }

        public string GetRomanNumeral(int number)
        {
            if (Valid(number))
            {
                var units = getUnits(number);
                var tens = getTens(number, units);
                var hundreds = getHundreds(number, tens, units);
                var thousands = getThousands(number, hundreds, tens, units);
                var romanNumeral = getRomanNumber(thousands, hundreds, tens, units);

                return romanNumeral;
            }
            return string.Empty;
        }

        private bool Valid(int number)
        {
            return (number >= 0 && number < 4000);
        }

        private string getRomanNumber(int thousands, int hundreds, int tens, int units)
        {
            var unitsNumerals = romanNumeralsRepository.GetUnitNumerals(units);
            var tensNumerals = romanNumeralsRepository.GetTensNumerals(tens);
            var hundredsNumerals = romanNumeralsRepository.GetHundredsNumerals(hundreds);
            var thousandsNumerals = romanNumeralsRepository.GetThousandsNumerals(thousands);

            return $"{thousandsNumerals}{hundredsNumerals}{tensNumerals}{unitsNumerals}";
        }

        private int getThousands(int number, int hundreds, int tens, int units)
        {
            return (number - hundreds - tens - units);
        }

        private int getHundreds(int number, int tens, int units)
        {
            return (((number % 1000) - tens) - units);
        }

        private int getTens(int number, int units)
        {
            return (((number % 1000) % 100) - units);
        }

        private int getUnits(int number)
        {
            return (((number % 1000) % 100) % 10);
        }
    }
}