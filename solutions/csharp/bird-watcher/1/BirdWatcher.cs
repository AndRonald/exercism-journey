class BirdCount
{
    private int[] BirdsPerDay = new int[]{2, 5, 0, 7, 4, 1};

    public BirdCount(int[] birdsPerDay)
    {
        BirdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastWeek = new int[] { 0, 2, 5, 3, 7, 8, 4 }; 
        return lastWeek;
    }

    public int Today()
    {
        var lastIndex = BirdsPerDay[BirdsPerDay.Length -1];
        return lastIndex;
    }

    public void IncrementTodaysCount()
    {
        int lastIndex = BirdsPerDay.Length - 1;
        BirdsPerDay[lastIndex] += 1; 
    }

    public bool HasDayWithoutBirds()
    {
        foreach(var item in BirdsPerDay)
        {
            if(item == 0)
                return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;
        for(int i = 0; i < numberOfDays; i++)
        {
            sum += BirdsPerDay[i];    
        } 
        return sum;
    }

    public int BusyDays()
    {
        int movementDays = 0;
        
        foreach(var item in BirdsPerDay)
        {
            if(item >= 5)
            {
                movementDays += 1;
            }
        }
        return movementDays;
    }
}
