public abstract class Vehicle 
{
    public string Name;
    public int Passengers;
    public string Color;
    public bool HasEngine;
    public int Miles;

// Constructors
// A constructor that allows a user to fill in all fields (except distance traveled)
// A constructor that only allows a user to fill in name and color and provides default values for all other fields (you can assume it will become some sort of car)
    
    public Vehicle(string name, int passengers, string color, bool hasEngine)
    {
        Name = name;
        Passengers = passengers;
        Color = color;
        HasEngine = hasEngine;
        Miles = 0;
    }
    public Vehicle(string name, string color)
    {
        Name = name;
        Passengers = 4;
        Color = color;
        HasEngine = true;
        Miles = 0;
    }


    // Methods
    // A method called ShowInfo() prints out all the information about the vehicle
    // A method called Travel() accepts input for distance, adds that distance to the total distance traveled, and prints out a message saying how far the vehicle has gone

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Passengers: {Passengers}, Color: {Color}, Has Engine: {HasEngine}, Miles: {Miles}");

    }
    public void Travel(int distance)
    {
        Miles += distance;
        Console.WriteLine($"Vehicle has travelled {Miles}");
        
    }
}