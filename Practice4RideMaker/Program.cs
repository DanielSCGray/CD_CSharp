// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Create at least 4 different vehicles using any of the constructors (use each constructor at least once)
Vehicle Honda = new ("Accord", "red");
Vehicle Honda2 = new ("Civic", "red");
Vehicle Ford = new ("F-150", "black");
Vehicle Toyota = new ("Camry", "white");
Vehicle Dodge = new ("Charger", "yellow");


// Put all the vehicles you created into a List
List<Vehicle> vList = new();
vList.Add(Honda);
vList.Add(Honda2);
vList.Add(Ford);
vList.Add(Toyota);
vList.Add(Dodge);
// Loop through the List and have each vehicle run its ShowInfo() method
foreach (var item in vList)
{
    item.ShowInfo();
}
// Make one of the vehicles Travel 100 miles
Honda.Travel(100);
// Print the information of the vehicle to verify the distance traveled went up
Honda.ShowInfo();
// Bonuses:
// Test this: manually set the distance traveled field to 350 and print the information. If your field was public, this will work. Why is this not the best practice to allow our users to change the distance traveled without going through the Travel() method?
Ford.Miles=350;
Ford.ShowInfo();

// Once you know the answer, make the distance traveled field private. How does this affect the code in Program.cs? Why is this better for us? Write comments in your code explaining your reasoning.

