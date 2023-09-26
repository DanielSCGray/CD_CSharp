public class Soda : Drink
{
    public bool IsDiet;

    public Soda(string name, string color, double temperature, int calories, bool isdiet) :base(name, color, temperature, true, calories)
    {
        IsDiet = isdiet;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Diet? {IsDiet}");
        
    }
}