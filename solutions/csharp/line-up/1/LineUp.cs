public static class LineUp
{
    public static string Format(string name, int number)
    {
        return $"{name}, you are the {number}{GetOrdinal(number)} customer we serve today. Thank you!";
    }

    public static string GetOrdinal(int number)
    {
        int lastTwoDigits = Math.Abs(number % 100);
        if (lastTwoDigits != 11 && lastTwoDigits != 12 && lastTwoDigits != 13)
        {
            if (number % 10 == 1) return "st";
            if (number % 10 == 2) return "nd";
            if (number % 10 == 3) return "rd";
        }
        return "th";
    }
}
