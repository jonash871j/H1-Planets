using System;
using System.Collections.Generic;

class Program
{
    /// <summary>
    /// Prints all the planets in a list
    /// </summary>
    static void PrintPlanets(List<Planet> planets)
    {
        foreach (Planet planet in planets)
        {
            Console.WriteLine("\n- - - - - - - - - - - - - -");
            Console.WriteLine("            Name : " + planet.Name);
            Console.WriteLine("   Clssification : " + planet.GetClassificationDefinition());
            Console.WriteLine("            Mass : " + planet.Mass + "kg");
            Console.WriteLine("        Diameter : " + planet.Diameter + "km");
            Console.WriteLine("         Density : " + planet.Density + "kg/m^3");
            Console.WriteLine("         Gravity : " + planet.Gravity + "m/s^2");
            Console.WriteLine(" Rotation period : " + planet.RotationPeriod + "hours");
            Console.WriteLine("      Day length : " + planet.DayLength + "hours");
            Console.WriteLine(" Distance to sun : " + planet.DistanceToSun * Math.Pow(10, 5) + "km");
            Console.WriteLine("  Orbital period : " + planet.OrbitalPeriod + "days");
            Console.WriteLine("Orbital velocity : " + planet.OrbitalVelocity + "km/s");
            Console.WriteLine("Mean temperature : " + planet.MeanTemperature + "C°");
            Console.WriteLine("           Moons : " + planet.MoonAmount);
            Console.WriteLine("     Ring system : " + planet.RingSystem);
        }
    }

    static void EndMessage(string message)
    {
        Console.WriteLine(message);
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }

    static void Main(string[] args)
    {
        // Creates 9 planets
        Planet mercury = new Planet("Mercury", PlanetClassification.Planet, 0.333, 4879, 5427, 3.7, 1407.6, 4222.6, 57.9, 88, 47.4, 167, 0, false);
        Planet venus = new Planet("Venus", PlanetClassification.Planet, 4.87, 12104, 5243, 8.9, -5832.5, 2802.0, 108.2, 224.7, 35, 464, 0, false);
        Planet earth = new Planet("Earth", PlanetClassification.Planet, 5.97, 12756, 5514, 9.8, 23.9, 24, 149.6, 365.2, 29.8, 15, 1, false);
        Planet mars = new Planet("Mars", PlanetClassification.Planet, 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687, 24.1, -65, 2, false);
        Planet jupiter = new Planet("Jupiter", PlanetClassification.Planet, 1898, 142984, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, true);
        Planet saturn = new Planet("Saturn", PlanetClassification.Planet, 568, 120536, 687, 9, 10.7, 10.7, 1433.5, 10.747, 9.7, -140, 62, true);
        Planet uranus = new Planet("Uranus", PlanetClassification.Planet, 86.8, 51118, 1271, 8.7, -17.2, 17.2, 2872.5, 30.589, 6.8, -195, 27, true);
        Planet neptune = new Planet("Neptune", PlanetClassification.Planet, 102, 49528, 1638, 11, 16.1, 16.1, 4495.1, 59.8, 4.4, -200, 14, true);
        Planet pluto = new Planet("Pluto", PlanetClassification.DwarfPlanet, 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -225, 5, false);

        // Creates a planet list with 8 of the planets
        List<Planet> planets = new List<Planet>() { mercury, earth, mars, jupiter, saturn, uranus, neptune, pluto };

        PrintPlanets(planets);
        EndMessage("Printed planets without Venus");

        // Inserts venus to the list at position 1
        planets.Insert(1, venus);
        PrintPlanets(planets);
        EndMessage("Printed planets with Venus");

        // Removes pluto from the list at position 8
        planets.RemoveAt(8);
        PrintPlanets(planets);
        EndMessage("Printed planets without Pluto");

        // Adds pluto back to the list
        planets.Add(pluto);
        PrintPlanets(planets);
        EndMessage("Printed planets with Pluto added again");

        // Prints the amount of planets in the list
        EndMessage("Amount of planet in the list is " + planets.Count);

        // Creates new list
        List<Planet> planetsCold = new List<Planet>();

        // Loops through planets a checks if temperature less than 0 then add it to the new list
        foreach (Planet planet in planets)
            if (planet.MeanTemperature < 0)
                planetsCold.Add(planet);

        PrintPlanets(planetsCold);
        EndMessage("Printed all planets under 0 degree");

        // Create new list
        List<Planet> planetsBig = new List<Planet>();

        // Loops through planets a checks if diameter is more than 10000 and less than 50000, then add it to new list
        foreach (Planet planet in planets)
            if ((planet.Diameter > 10000) && (planet.Diameter < 50000))
                planetsBig.Add(planet);

        PrintPlanets(planetsBig);
        EndMessage("Printed all width diameter over 10000km and less than 50000km");

        // Clears all the lists
        planets.Clear();
        planetsCold.Clear();
        planetsBig.Clear();
        Console.WriteLine("List cleared");
    }
}
