public class SpaceAge
{
    private readonly int _seconds;
    private const double EarthInSeconds = 31557600;
    private const double Terra = 1.0;
    private const double Mercury = 0.2408467;
    private const double Venus = 0.61519726;
    private const double Marte = 1.8808158;
    private const double Jupiter = 11.862615;
    private const double Saturno = 29.447498;
    private const double Urano = 84.016846;
    private const double Neptune = 164.79132;
    
    private double CalculateAge(double period) => _seconds / (EarthInSeconds * period);
    
    public SpaceAge(int seconds)
    {
      _seconds = seconds;
    }

    public double OnEarth()
    {
        return CalculateAge(Terra);
    }

    public double OnMercury()
    {
        return CalculateAge(Mercury);
    }

    public double OnVenus()
    {
        return CalculateAge(Venus);    
    }

    public double OnMars()
    {
        return CalculateAge(Marte);
    }

    public double OnJupiter()
    {
        return CalculateAge(Jupiter);
    }

    public double OnSaturn()
    {
        return CalculateAge(Saturno);
    }

    public double OnUranus()
    {
        return CalculateAge(Urano);
    }

    public double OnNeptune()
    {
        return CalculateAge(Neptune);    
    }
}