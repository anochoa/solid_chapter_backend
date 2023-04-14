namespace SOLID.LUTINHA;

public class Weapon
{
    public Weapon(string name, double strengthPoints, int durability)
    {
        Name = name;
        StrengthPoints = strengthPoints;
        StrengthMultiplier = 1;
        Durability = durability;
    }

    public Weapon(string name, double strengthPoints, double strengthMultiplier, int durability)
    {
        Name = name;
        StrengthPoints = strengthPoints;
        StrengthMultiplier = strengthMultiplier;
        Durability = durability;
    }

    private string Name;
    public double StrengthPoints { get; private set; }
    public double StrengthMultiplier {get; private set;}
    private int Durability;

    public virtual double Damage()
    {
        return StrengthPoints * StrengthMultiplier;
    }
}