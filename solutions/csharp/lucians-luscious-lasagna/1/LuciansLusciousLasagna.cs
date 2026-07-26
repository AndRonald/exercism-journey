class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method

    public int ExpectedMinutesInOven() => 40;

    // TODO: define the 'RemainingMinutesInOven()' method

    public int RemainingMinutesInOven(int value)
    {
        if(value > 40)
            return 0;
        return (40 - value);
    } 
    // TODO: define the 'PreparationTimeInMinutes()' method

    public int PreparationTimeInMinutes(int x) => x * 2;
    // TODO: define the 'ElapsedTimeInMinutes()' method

    public int ElapsedTimeInMinutes(int x, int y) => (x * 2) + y;
}
