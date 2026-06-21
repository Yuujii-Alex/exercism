class BirdCount
{
    private int[] birdsPerDay;

    private static int[] lastWeekCounts = { 0, 2, 5, 3, 7, 8, 4 };

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return lastWeekCounts;
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1]; 
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (var bird in birdsPerDay)
        {
            if (bird == 0)
                return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int total = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            total += birdsPerDay[i];
        }
        return total;
    }

    public int BusyDays()
    {
        int total = 0;
        foreach (var bird in birdsPerDay)
        {
            if (bird >= 5)
                total++;
        }
        return total;
    }
}