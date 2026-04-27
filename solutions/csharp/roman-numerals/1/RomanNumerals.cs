using System;

public static class RomanNumeralExtension
{
    private static readonly Dictionary<int, string> RomanNumerals = new Dictionary<int, string>
    {
        { 1000, "M" },
        { 900, "CM" },
        { 500, "D" },
        { 400, "CD" },
        { 100, "C" },
        { 90, "XC" },
        { 50, "L" },
        { 40, "XL" },
        { 10, "X" },
        { 9, "IX" },
        { 5, "V" },
        { 4, "IV" },
        { 1, "I" }
    };

    public static string ToRoman(this int value)
    {
        if (value <= 0)
            return string.Empty;

        foreach (var item in RomanNumerals)
        {
            if (value >= item.Key)
                return item.Value + ToRoman(value - item.Key);
        }
        
        return string.Empty;
    }
}