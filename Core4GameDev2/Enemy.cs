
public class Enemy 
{
    public string Name;
    private int _Health;
    public int Health
    {
        get {return _Health; }
        set { _Health = value;}
    }
    public List<Attack> AttackList {get; set;}

    public Enemy(string name, int health=100)
    {
        Name = name;
        Health = health;
        _Health = health;
        AttackList = new();
        
    }

    public int RandomAttack()
    {
        Random rand = new Random();
        int i = rand.Next(AttackList.Count);
        Attack randAttack = AttackList[i];
        Console.WriteLine($"{Name} attacks with {randAttack.Name} for {randAttack.Damage} damage!");
        return randAttack.Damage;
        
    }

    public virtual void PerformAttack(Enemy target, Attack atk)
    {
        target.Health -= atk.Damage;
        Console.WriteLine($"{Name} attacks {target.Name} using {atk.Name} and deals {atk.Damage} damage!");
        Console.WriteLine($"{target.Name}'s health is now {target.Health}");
        
        
    }

}
