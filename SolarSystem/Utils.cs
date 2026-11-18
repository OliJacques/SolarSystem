using System;
using System.Linq;
using System.Collections.Generic;

namespace SolarSystem;

public static class Utils
{
    public static string DisplayMenu()
    {
        Console.Write(
            "===== Solar System Explorer =====\n " +
            "\n1. Display all planets" +
            "\n2. Display details of a planet" +
            "\n3. Display a planet's moons" +
            "\n4. Display the mass of a planet" +
            "\n5. Check whether a planet exists" +
            "\n6. Display Planets in Alphabetical Order" +
            "\n7. Display Planets based on distance from Sun" +
            "\n8. Display Planet with Most moons" +
            "\n9. Display Total moon count" +
            "\n0. Exit" +
            "\nEnter your choice: "
        );
        return Console.ReadLine();
    }
}