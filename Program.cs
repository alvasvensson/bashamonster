using BashMonster;

Gubbe martin = new();
Gubbe micke = new();

martin.hp = 100;
micke.hp = 60;

Enemy hampus = new();
Enemy hector = new();

Weapon sword = new();

Console.WriteLine("Vill du ta upp vapnet?");
string isWeaponEquipped = Console.ReadLine();

if (isWeaponEquipped == "y")
{
    sword.equipped = true;
}

if (sword.equipped = true)
{
    Console.WriteLine("do you want to hit the enemy");
    string yesFight = Console.ReadLine();
    if (yesFight == "y")
    {
        hampus.hp -= sword.dmg;
        Console.WriteLine($"Hampus has {hampus.hp} hp left");
    }
}


Console.ReadLine();