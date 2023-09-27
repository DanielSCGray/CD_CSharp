public class Horse : Vehicle, INeedFuel
{
    public string FuelType {get;set;}
    public int FuelTotal {get;set;}
    public Horse(string name, int passengers, string color) : base(name, 1, color, false)
    {
        FuelType = "Hay";
        FuelTotal = 10;
    }

    public void GiveFuel(int Amount)
    {
        FuelTotal += Amount;

    }
}