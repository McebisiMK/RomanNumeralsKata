using System;

namespace RomanNumeralsKata
{
    internal class RomanNumeralsService
    {
        private IRomanNumeralsRepository romanNumeralsRepository;

        public RomanNumeralsService(): this(new RomanNumeralsRepository())
        {

        }

        public RomanNumeralsService(RomanNumeralsRepository romanNumeralsRepository)
        {
            this.romanNumeralsRepository = romanNumeralsRepository;
        }

        public string GetRomanNumeral(int number)
        {
            var units = getUnits(number);
            var tens = getTens(number,units);
            var hundreds = getHundreds(number, tens, units);
            var unitsNumerals = romanNumeralsRepository.GetUnitNumerals(units);
            var tensNumerals = romanNumeralsRepository.GetTensNumerals(tens);
            var hundredsNumerals = romanNumeralsRepository.GetHundredsNumerals(hundreds);

            return $"{hundredsNumerals}{tensNumerals}{unitsNumerals}";
        }

        private int getHundreds(int number, int tens, int units)
        {
            return (((number % 1000)- tens) - units);
        }

        private int getTens(int number,int units)
        {
            return (((number % 1000) % 100) - units);
        }

        private int getUnits(int number)
        {
            return (((number % 1000) % 100) % 10);
        }
    }
}