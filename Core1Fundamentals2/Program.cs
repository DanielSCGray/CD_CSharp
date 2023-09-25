// See https://aka.ms/new-console-template for more information


Console.WriteLine("");

// Three Basic Arrays
// Create an integer array with the values 0 through 9 inside.
int[] numArray = {0,1,2,3,4,5,6,7,8,9};
// Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".
string[] strArray = {"Tim", "Martin", "Nikki", "Sara"};
// Create a boolean array of length 10. Then fill it with alternating true/false values, starting with true. (Tip: do this using logic! Do not hard-code the values in!)
bool[] boolArray = {true, false, true, false, true, false, true, false, true, false};
// List of Flavors
// Create a string List of ice cream flavors that holds at least 5 different flavors. (Feel free to add more than 5!)
List<string> flavors = new List<string>()
{
    "vanilla",
    "chocolate",
    "strawberry",
    "mint chip",
    "cookie dough"
};
// Output the length of the List after you added the flavors.
Console.WriteLine(flavors.Count);
// Output the third flavor in the List.
Console.WriteLine(flavors[2]);

// Now remove the third flavor using its index location.
flavors.RemoveAt(2);
// Output the length of the List again. It should now be one fewer.
Console.WriteLine(flavors.Count);

// User Dictionary
// Create a dictionary that will store string keys and string values.
Dictionary<string,string> dict = new();
// Add key/value pairs to the dictionary where:
// Each key is a name from your names array (this can be done by hand or using logic)
// Each value is a randomly selected flavor from your flavors List (remember Random from earlier?)
Random rand = new Random();
Console.WriteLine(rand.Next(1,10));
for (int i = 0; i < strArray.Length; i++)
{
    int randInt = rand.Next(0, flavors.Count);
    dict.Add(strArray[i], flavors[randInt]);
}
// Loop through the dictionary and print out each user's name and their associated ice cream flavor.
foreach (KeyValuePair<string,string> entry in dict)
{
    Console.WriteLine($"{entry.Key}'s favorite ice cream is {entry.Value}");
}
