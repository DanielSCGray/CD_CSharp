// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Soda Coke = new("Coke", "brown", 60.5, 140, false);
Soda DietCoke = new("Diet Coke", "brown", 60.5, 0, true);
Coffee BlackCoffee = new("Black Coffee", "Black", 115.8, 60, "dark", "normal?");
Coffee IcedCoffee = new("Iced Coffee", "Beige", 40.3, 180, "light", "vanilla infused");
Wine RedWine = new("Red Wine", "Red", 70.2, 125, "Spain", 2010);
Wine WhiteWine = new("White Wine", "Yellow", 70.2, 125, "France", 2010);


// Coke.ShowInfo();

// DietCoke.ShowInfo();

// BlackCoffee.ShowInfo();
// IcedCoffee.ShowInfo();
// RedWine.ShowInfo();

List<Drink> DrinkList = new(){Coke, DietCoke, BlackCoffee, IcedCoffee, RedWine, WhiteWine};

foreach (Drink drink in DrinkList)
{
    drink.ShowInfo();
}
