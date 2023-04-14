using System.Diagnostics;

namespace SOLID.LUTINHA;

public class Character
{
    //Evitando a "Primitive Obsession"
    private CharacterInfo _characterInfo;

    //Responsabilidades externas (Composição)
    private Weapon? _weapon;
    private Armor? _armor;

    public Character(CharacterInfo characterInfo)
    {
        _characterInfo = characterInfo;
    }

    public void IntroducingMySelf()
    {
        Console.WriteLine(
            $" Olá, eu sou o {_characterInfo.Name}, estou no level {_characterInfo.Level}, atualmente minhas estatisticas são: Mana {_characterInfo.ManaPoints}, Força {_characterInfo.StrengthPoints}, Pontos de vida {_characterInfo.HealthPoints}");
    }

    public void Statistics()
    {
        //IF ternario pro Vini ficar feliz
        var died = _characterInfo.HealthPoints <= 0 ? "EU MORRI :( " : "";
        
        Console.WriteLine(
            $" {_characterInfo.Name} {died} Mana {_characterInfo.ManaPoints}, Força {_characterInfo.StrengthPoints}, Pontos de vida {_characterInfo.HealthPoints}");
    }

    public double CurrentLifePoints()
    {
        return _characterInfo.HealthPoints;
    }

    public void EquipWeapon(Weapon weapon)
    {
        _weapon = weapon;
    }

    public void EquipArmor(Armor armor)
    {
        _armor = armor;
    }

    public double Attack(Character enemy)
    {
        Console.WriteLine($"{_characterInfo.Name} ao ataque o/ ");

        if (_weapon == null)
            return enemy.TakeDamage(_characterInfo.StrengthPoints);
        
        return enemy.TakeDamage(
            _weapon.Damage()
        );
    }

    public double TakeDamage(double damage)
    {
        if (_armor == null)
            return _characterInfo.ReduceHealthPoints(damage);

        return _characterInfo.ReduceHealthPoints(
            _armor.ReduceDamage(damage)
        );
    }
}