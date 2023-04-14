namespace SOLID.LUTINHA;

public class CharacterInfo
{
    public CharacterInfo(string name, int level, double healthPoints, double manaPoints, double strengthPoints)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Level = level;
        HealthPoints = healthPoints;
        ManaPoints = manaPoints;
        StrengthPoints = strengthPoints;
    }

    public double ReduceHealthPoints(double damage)
    {
        HealthPoints -= damage;
        return HealthPoints;
    }
    
    public string Name { get; private set; }
    public int Level { get; private set; }
    public double HealthPoints { get; private set; }
    public double ManaPoints { get; private set; }
    public double StrengthPoints { get; private set; }
}