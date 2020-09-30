
public enum PlanetClassification
{
    Planet = 0,
    DwarfPlanet = 1,
};

public class Planet
{
    public string Name { get; private set; }
    public PlanetClassification Classification { get; private set; }
    public double Mass { get; private set; }
    public double Diameter { get; private set; }
    public double Density { get; private set; }
    public double Gravity { get; private set; }
    public double RotationPeriod { get; private set; }
    public double DayLength { get; private set; }
    public double DistanceToSun { get; private set; }
    public double OrbitalPeriod { get; private set; }
    public double OrbitalVelocity { get; private set; }
    public double MeanTemperature { get; private set; }
    public int MoonAmount { get; private set; }
    public bool RingSystem { get; private set; }

    public Planet(string name, PlanetClassification classification, double mass, double diameter, double density,
        double gravity, double rotationPeriod, double dayLength, double distanceToSun, double orbitalPeriod, 
        double orbitalVelocity, double meanTemperature, int moonAmount, bool ringSystem)
    {
        Name = name;
        Classification = classification;
        Mass = mass;
        Gravity = gravity;
        Diameter = diameter;
        Density = density;
        RotationPeriod = rotationPeriod;
        DayLength = dayLength;
        DistanceToSun = distanceToSun;
        OrbitalPeriod = orbitalPeriod;
        OrbitalVelocity = orbitalVelocity;
        MeanTemperature = meanTemperature;
        MoonAmount = moonAmount;
        RingSystem = ringSystem;
    }
    /// <summary>
    /// Get planet classification
    /// </summary>
    /// <returns>message</returns>
    public string GetClassificationDefinition()
    {
        switch(Classification)
        {
        case PlanetClassification.Planet:
            return "planet";
        case PlanetClassification.DwarfPlanet:
            return "dwarf planet";
        default:
            return "none";
        }
    }
}
