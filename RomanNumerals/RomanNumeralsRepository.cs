using System;
using System.Collections.Generic;

namespace RomanNumeralsKata
{
    public class RomanNumeralsRepository : IRomanNumeralsRepository
    {

        public string GetHundredsNumerals(int number)
        {
            var romanNumerals = new Dictionary<int, string>();

            romanNumerals.Add(0, "");
            romanNumerals.Add(100, "C");
            romanNumerals.Add(200, "CC");
            romanNumerals.Add(300, "CCC");
            romanNumerals.Add(400, "CD");
            romanNumerals.Add(500, "D");
            romanNumerals.Add(600, "DC");
            romanNumerals.Add(700, "DCC");
            romanNumerals.Add(800, "DCCC");
            romanNumerals.Add(900, "CM");

            return romanNumerals[number];
        }

        public string GetTensNumerals(int number)
        {
            var romanNumerals = new Dictionary<int, string>();

            romanNumerals.Add(0, "");
            romanNumerals.Add(10, "X");
            romanNumerals.Add(20, "XX");
            romanNumerals.Add(30, "XXX");
            romanNumerals.Add(40, "XL");
            romanNumerals.Add(50, "L");
            romanNumerals.Add(60, "LX");
            romanNumerals.Add(70, "LXX");
            romanNumerals.Add(80, "LXXX");
            romanNumerals.Add(90, "XC");

            return romanNumerals[number];
        }

        public string GetThousandsNumerals(int number)
        {
            var romanNumerals = new Dictionary<int, string>();

            romanNumerals.Add(0, "");
            romanNumerals.Add(1000, "M");
            romanNumerals.Add(2000, "MM");
            romanNumerals.Add(3000, "MMM");

            return romanNumerals[number];
        }

        public string GetUnitNumerals(int number)
        {
            var romanNumerals = new Dictionary<int, string>();

            romanNumerals.Add(0, "");
            romanNumerals.Add(1, "I");
            romanNumerals.Add(2, "II");
            romanNumerals.Add(3, "III");
            romanNumerals.Add(4, "IV");
            romanNumerals.Add(5, "V");
            romanNumerals.Add(6, "VI");
            romanNumerals.Add(7, "VII");
            romanNumerals.Add(8, "VIII");
            romanNumerals.Add(9, "IX");

            return romanNumerals[number];
        }
    }
}