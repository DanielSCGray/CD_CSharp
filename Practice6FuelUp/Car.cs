public class Car : Vehicle, INeedFuel
{
    public string FuelType {get;set;}
    public int FuelTotal {get;set;}
    public Car(string name, int passengers, string color) : base(name, passengers, color, true)
    {
        FuelType = "Gas";
        FuelTotal = 10;
    }

    public void GiveFuel(int Amount)
    {
        FuelTotal += Amount;

    }
}