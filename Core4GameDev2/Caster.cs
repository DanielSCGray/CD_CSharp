public class Caster : Enemy
{
    

    public Caster(string name) : base(name, 80)
    {
        Attack Fireball = new("Fireball", 25);
        Attack LightningBolt = new("Lightning Bolt", 20);
        Attack StaffStrike = new("Staff Strike", 10);
        AttackList = new() {
            Fireball,LightningBolt,StaffStrike
        };
    }

    public void Heal(Enemy target)
    {
        target.Health += 40;
        Console.WriteLine($"{Name} heals {target.Name} up to {target.Health} health.");
        

    }
}