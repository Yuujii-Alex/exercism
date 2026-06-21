public class SpaceAge
{
    private double age;
    public SpaceAge(int seconds)
    {
        this.age = (double)seconds / (60 * 60 * 24 * 365.25);
    }

    public double OnEarth() => age / 1.0;
    public double OnMercury() => age / 0.2408467;
    public double OnVenus() => age / 0.61519726;
    public double OnMars() => age / 1.8808158;
    public double OnJupiter() => age / 11.862615;
    public double OnSaturn() => age / 29.447498;
    public double OnUranus() => age / 84.016846;
    public double OnNeptune() => age / 164.79132;
}