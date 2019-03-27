namespace RomanNumeralsKata
{
    public interface IRomanNumeralsRepository
    {
        string GetUnitNumerals(int number);
        string GetTensNumerals(int number);
        string GetHundredsNumerals(int number);
        string GetThousandsNumerals(int number);
    }
}