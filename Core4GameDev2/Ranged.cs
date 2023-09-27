public class Ranged : Enemy
{
    public int Distance;

    public Ranged(string name) : base(name)
    {
        Attack Shoot = new("Shoot", 20);
        Attack Throw = new("Throw", 15);
        AttackList = new() {
            Shoot,Throw
        };
        Distance = 5;
    }

    public override void PerformAttack(Enemy target, Attack atk)
    {
        if (Distance<10)
        {
            Console.WriteLine($"Distance must be at least 10, current Distance is {Distance}");
            return;
        }
        base.PerformAttack(target, atk);
    }
    
    public void Dash()
    {
        Distance = 20;
    }
    
}