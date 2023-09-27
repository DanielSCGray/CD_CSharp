public class Melee : Enemy
{
    

    public Melee(string name) : base(name, 120)
    {
        Attack Punch = new("Punch", 20);
        Attack Kick = new("Kick", 15);
        Attack Tackle = new("Tackle", 25);
        AttackList = new() {
            Punch,Kick,Tackle
        };
    }

    public void Rage(Enemy target)
    {
        Random rand = new Random();
        int i = rand.Next(AttackList.Count);
        int totalDamage = AttackList[i].Damage +10;
        target.Health -= totalDamage;
        Console.WriteLine($"{Name} IS ENRAGED!!! They attack {target.Name} using {AttackList[i].Name} and deal {totalDamage} damage!");
        Console.WriteLine($"{target.Name}'s health is now {target.Health}");
        
        
    }
    
}