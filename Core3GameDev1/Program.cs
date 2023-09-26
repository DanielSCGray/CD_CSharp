// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Attack Punch = new("Punch", 5);
Attack Kick = new("Kick", 10);
Attack Fireball = new("Fireball", 15);

Enemy Henchman = new("Henchman One");

Henchman.AttackList.Add(Punch);
Henchman.AttackList.Add(Kick);
Henchman.AttackList.Add(Fireball);

Henchman.RandomAttack();