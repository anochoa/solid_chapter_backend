namespace SOLID.LUTINHA;

public class Armor
{
    public Armor(string name, double defenceStrength, int durability)
    {
        Name = name;
        DefenceStrength = defenceStrength;
        Durability = durability;
    }

    private string Name;
    private double DefenceStrength;
    private int Durability;

    public double ReduceDamage(double damage)
    {
        return  Math.Max(0, damage - DefenceStrength);
    }
}