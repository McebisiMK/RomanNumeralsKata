using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    public interface IRomanNumeralsDataService
    {
        string GetUnitsRomanNumeral(int number);
        string GetTensRomanNumeral(int number);
        string GetHundredsRomanNumeral(int number);
        string GetThousandsRomanNumeral(int number);
    }
}
