namespace SolarSystem;

public class SolarSystem
{
    List<Planet> planetList;
    public string DisplayMenu()
    {
        Console.WriteLine(
            "===== Solar System Explorer =====\n " +
            "\n1. Display all planets" +
            "\n2. Display details of a planet" +
            "\n3. Display a planet's moons" +
            "\n4. Display the mass of a planet" +
            "\n5. Check whether a planet exists" +
            "\n0. Exit\n " +
            "\nEnter your choice:\n"
        );
        
        return Console.ReadLine();
    }

    public void DisplayPlanets()
    {
        Console.WriteLine("Current Planets in Solar System:");
        foreach (Planet planet in planetList)
        {
            Console.WriteLine(planet.planetName);
        }
    }

    public void FetchAndDisplayPlanet()
    {
        Planet? planetData = FindPlanet();
        if (planetData == null) return;
        
        Console.WriteLine(
            "Name: {0}\n" +
            "Mass: {1}\n" +
            "Distance from Sun: {2}\n" +
            "Length of Day: {3} hours\n" +
            "Moon Count: {4}\n" +
            "Moons: {5}", planetData.planetName, planetData.planetMass, planetData.planetDistanceToSun, planetData.planetDayLength, planetData.planetMoonCount, planetData.planetMoonList);
        
    }

    public void FetchPlanetsMoons()
    {
        Planet? planetData = FindPlanet();
        if (planetData == null) return;

        Console.WriteLine("Moons:");
        foreach (Moon moon in planetData.moons)
        {
            Console.WriteLine("- {0}", moon.moonName);
        }
    }

    public void FetchAndDisplayPlanetMass()
    {
        Planet? planetData = FindPlanet();
        if (planetData == null) return;

        Console.WriteLine("Mass: {0}", planetData.planetMass);
    }

    public Planet? FindPlanet()
    {
        Console.WriteLine("Enter planet name:");
        string? planetName = Console.ReadLine();
        
        Planet? planetData = planetList.Find(planet => planet.planetName.ToLower() == planetName.ToLower());

        if (planetData == null)
        {
            Console.WriteLine("{0} is not in the list of planets", planetName);
            return null;
        }

        return planetData;
    }
}