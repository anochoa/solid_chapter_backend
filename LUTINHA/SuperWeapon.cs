namespace SOLID.LUTINHA;

public class SuperWeapon : Weapon
{
    public SuperWeapon(string name, double strengthPoints, int durability) :
        base(name, strengthPoints, durability)
    {
    }

    public SuperWeapon(string name, double strengthPoints, double strengthMultiplier, int durability) :
        base(name, strengthPoints, strengthMultiplier, durability)
    {
    }

    public override double Damage()
    {
        return (StrengthPoints * StrengthMultiplier) * 100;
    }
}