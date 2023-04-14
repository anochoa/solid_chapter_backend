using SOLID.LUTINHA;


/***
 *  E esse codigo feião aqui é só para executar as classes 
 */

Console.WriteLine("Bora lutar?");
Console.WriteLine("Chamando o Jorginho");
var jorginho = new Character(new CharacterInfo("Jorginho", 10, 1000, 1000, 100));
jorginho.IntroducingMySelf();

Console.WriteLine("Chamando o Big ED");
var bigEd = new Character(new CharacterInfo("Big Ed", 7, 700, 700, 70));
bigEd.IntroducingMySelf();

Console.WriteLine();
Console.WriteLine("Então vamos ao ataque");
Console.WriteLine("=====================================");

Random random = new Random();
int count = 0;

do
{
    int randomAttacker = random.Next(1, 3);

    // Distribuindo itens
    if (count > 1)
    {
        int randomItemController = random.Next(1, 11);
        double randomMultiplier = random.NextDouble() * random.Next(-21, 21);
        double randomDefenceStrength = random.NextDouble() * random.Next(-100, 100);
        int ramdomSuperWeapon = random.Next(0, 100);
        
        Console.WriteLine($"Multiplicador de força: {randomMultiplier}");
        Console.WriteLine($"Força da armadura: {randomDefenceStrength}");
        //Console.WriteLine($"{ramdomSuperWeapon}");

        var _armor = new Armor("Armadura do sol", (randomDefenceStrength), 1);
        var _weapon = new Weapon("Sabre de luz", (50), randomMultiplier, 1);

        if (ramdomSuperWeapon >= 80)
        {
            Console.WriteLine("SUPER ARMA");
            _weapon = new SuperWeapon("Super sabre de luz", (50), randomMultiplier, 1);
        }

        if (randomItemController % 2 == 0)
        {
            jorginho.EquipArmor(_armor);
            bigEd.EquipWeapon(_weapon);
        }
        else
        {
            bigEd.EquipArmor(_armor);
            jorginho.EquipWeapon(_weapon);
        }
    }

    Console.WriteLine("----------------");


    if (randomAttacker == 1)
        jorginho.Attack(bigEd);
    else
        bigEd.Attack(jorginho);

    jorginho.Statistics();
    bigEd.Statistics();

    Console.WriteLine("----------------");

    count++;
    Thread.Sleep(1000);
} while (bigEd.CurrentLifePoints() > 0 && jorginho.CurrentLifePoints() > 0);

Console.WriteLine("=====================================");
Console.WriteLine($"Luta Finalizada com {count} rodadas");

Console.ReadKey();