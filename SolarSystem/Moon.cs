namespace SolarSystem;

public class Moon
{
    public string moonName { get; private set; }
    public string moodOrbitalPeriod { get; private set; }
    public int moonDiscoverYear { get; private set; }
    
    public Moon(string name, string orbitalPeriod, int discoverYear)
    {
        moonName = name;
        moodOrbitalPeriod = orbitalPeriod;
        moonDiscoverYear = discoverYear;
    }
}