public class Wine : Drink
{
    public string Region;
    public int Year;
    public Wine(string name, string color, double temperature, int calories, string region, int year) :base(name, color, 70.3, false, calories)
    {
        Region = region;
        Year = year;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Region: {Region}");
        Console.WriteLine($"Year: {Year}");
        
    }
}