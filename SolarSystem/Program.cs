using System;
using System.Linq;
using System.Collections.Generic;

namespace SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            SolarSystem solarSystem = new SolarSystem();
            bool menuActive = true;
            do
            {
                string action = solarSystem.DisplayMenu();

                switch (action)
                {
                    case "1":
                        solarSystem.DisplayPlanets();
                        break;
                    case "2":
                        solarSystem.FetchAndDisplayPlanet();
                        break;
                    case "3":
                        solarSystem.FetchPlanetsMoons();
                        break;
                    case "4":
                        solarSystem.FetchAndDisplayPlanetMass();
                        break;
                    case "5":
                        solarSystem.FindPlanet();
                        break;
                    case "0":
                        menuActive = false;
                        break;
                }
            } while (menuActive);
        }
    }
}