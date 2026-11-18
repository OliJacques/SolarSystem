namespace SolarSystem;

public class SolarSystem
{
    List<Planet> planetList = new List<Planet>(){
        new Planet("Mercury", 0.330f, 57.9f, 4223, new List<Moon>()),
        new Planet("Venus", 4.87f, 108.2f, 2802, new List<Moon>()),
        new Planet("Earth", 5.97f, 149.6f, 24, new List<Moon>
        {
            new Moon("Moon", "27.3 days", 0)
        }),
        new Planet("Mars", 0.642f, 228.0f, 25, new List<Moon>
        {
            new Moon("Phobos", "0.32 days", 1877),
            new Moon("Deimos", "1.26 days", 1877)
        }),
        new Planet("Jupiter", 1898f, 778.5f, 10, new List<Moon>
        {
            new Moon("Io", "1.77 days", 1610),
            new Moon("Europa", "3.55 days", 1610),
            new Moon("Ganymede", "7.15 days", 1610),
            new Moon("Callisto", "16.69 days", 1610)
        }),
        new Planet("Saturn", 568f, 1432.0f, 11, new List<Moon>
        {
            new Moon("Mimas", "0.94 days", 1789),
            new Moon("Enceladus", "1.37 days", 1789),
            new Moon("Rhea", "4.52 days", 1672),
            new Moon("Titan", "15.95 days", 1655)
        }),

        new Planet("Uranus", 86.8f, 2867.0f, 17, new List<Moon>
        {
            new Moon("Miranda", "1.41 days", 1948),
            new Moon("Ariel", "2.52 days", 1851),
            new Moon("Umbriel", "4.14 days", 1851),
            new Moon("Titania", "8.71 days", 1787),
            new Moon("Oberon", "13.46 days", 1787)
        }),
        new Planet("Neptune", 102f, 4515.0f, 16, new List<Moon>
        {
            new Moon("Triton", "5.88 days", 1846),
            new Moon("Nereid", "360.1 days", 1949)
        })
    };

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

    public void FetchPlanetWithMostMoons()
    {
        planetList.Sort((a, b) => b.planetMoonCount.CompareTo(a.planetMoonCount));
        Planet planet = planetList[0];


        Console.WriteLine($"The planet with the most moons is {planet.planetName}, with {planet.planetMoonCount} moons.");
    }

    public void TotalMoonCount()
    {
        int moonTotal = planetList.Sum(planet => planet.planetMoonCount);

        Console.WriteLine("The total amount of moons in the Solar System is {0}", moonTotal);
    }

    public void FetchAndDisplayPlanetMass()
    {
        Planet? planetData = FindPlanet();
        if (planetData == null) return;

        Console.WriteLine("Mass: {0}", planetData.planetMass);
    }

    public void DisplayPlanetsInOrder(string order)
    {
        switch (order)
        {
            case "alphabetical":
                planetList.Sort();
                Console.WriteLine("Sorted in alphabetical order:");

                for (int i = 0; i < planetList.Count; i++)
                {
                    Console.Write(planetList[i].planetName + " ");
                }
                Console.WriteLine();
                break;
            case "distanceFromSun":
                planetList.Sort((a, b) => a.planetDistanceToSun.CompareTo(b.planetDistanceToSun));
                Console.WriteLine("Sorted by distance from the sun.");

                for (int i = 0; i < planetList.Count; i++)
                {
                    Console.Write(planetList[i].planetName + " - " + planetList[i].planetDistanceToSun + "\n");
                }
                break;
        }
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