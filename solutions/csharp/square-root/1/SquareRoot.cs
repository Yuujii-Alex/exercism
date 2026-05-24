public static class SquareRoot
{
    public static int Root(int number)
    {
        int l = 0;

        while ((l + 1) * (l + 1) <= number)
            l += 1;

        return l;
    }
}
