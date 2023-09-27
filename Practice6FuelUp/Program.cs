// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;

Console.WriteLine("Hello, World!");

Car Honda = new("Civic", 5, "blue");



Horse Horse = new("Altivo", 1, "white");

Bicycle Bike = new("Bike", 1, "green");

Console.WriteLine($"{Honda.Name} {Horse.Name} {Bike.Name}");

List<Vehicle> vList = new() {Honda, Horse, Bike};

List<INeedFuel> fList = new();

foreach (Vehicle vehicle in vList)
{
    if (vehicle is INeedFuel f)
    {
        fList.Add(f);
    }
}


foreach (INeedFuel fueler in fList)
{
    
    fueler.GiveFuel(10);
}

foreach (Vehicle v in fList)
{
    if(v is INeedFuel f)
    Console.WriteLine($"{v.Name} fuel : {f.FuelTotal}");
    
}