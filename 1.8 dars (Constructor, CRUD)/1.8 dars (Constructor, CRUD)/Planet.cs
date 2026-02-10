namespace _1._8_dars__Constructor__CRUD_;

public class Planet
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Diameter { get; set; }
    public bool LifePotential { get; set; }
    public bool ExistesOxygen { get; set; }
    public int Gravity { get; set; }

    public Planet()
    {
        
    }

    public Planet(string name, string description, double diameter, 
        bool lifepotential, bool existesOxygen, int gravity)
    {
        Name = name;
        Description = description;
        Diameter = diameter;
        LifePotential = lifepotential;
        ExistesOxygen = existesOxygen;
        Gravity = gravity;
    }
}
