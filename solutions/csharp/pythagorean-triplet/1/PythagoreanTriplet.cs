public static class PythagoreanTriplet
{
   public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        for (int a = 1; a < sum; a++)
        {
            for (int b = a + 1; b < sum; b++)
            {
                int c = sum - a - b;
    
                if (c > b && a * a + b * b == c * c)
                    yield return (a, b, c);
            }
        }
    }
}