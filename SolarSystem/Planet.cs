namespace SolarSystem;

public class Planet
{
    public string planetName { get; private set; }
    public float planetMass { get; private set; }
    public float planetDistanceToSun { get; private set; }
    public int planetDayLength { get; private set; }
    public int planetMoonCount { get; private set; }
    public string planetMoonList { get; private set; }
    
    public List<Moon> moons { get; private set; }

    public Planet(string name, float mass, float distanceToSun, int dayLength, List<Moon> moonList)
    {
        planetName = name;
        planetMass = mass;
        planetDistanceToSun = distanceToSun;
        planetDayLength = dayLength;
        moons = moonList;
        
        planetMoonCount = moonList.Count;
        planetMoonList = string.Join(", ", moonList.Select(moon => moon.moonName).ToList());
    }
}