// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 1. Iterate and print values

// Given a List of strings, iterate through the List and print out all the values. 
// Bonus: How many different ways can you find to print out the contents of a List? (There are at least 3! Check Google!)

static void PrintList(List<string> MyList)
{
    for (int i = 0; i < MyList.Count; i++)
    {
        Console.WriteLine(MyList[i]);
    }
}
List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
PrintList(TestStringList);

static void PrintList2(List<string> list)
{
    foreach (string name in list)
    {
        Console.WriteLine(name);
    }
}

PrintList2(TestStringList);

static void PrintList3(List<string> list)
{
    list.ForEach(Console.WriteLine);

}
PrintList3(TestStringList);
// 2. Print Sum

// Given a List of integers, calculate and print the sum of the values.

static void SumOfNumbers(List<int> list)
{
    int sum = 0;
    for (int i = 0; i < list.Count; i++)
    {
        sum += list[i];
    }
    Console.WriteLine(sum);
}
List<int> TestIntList = new List<int>() {2,7,12,9,3};
// You should get back 33 in this example
SumOfNumbers(TestIntList);



// 3. Find Max

// Given a List of integers, find and return the largest value in the List.
static int FindMax(List<int> list)
{
    int max = list[0];
    for (int i = 1; i < list.Count; i++)
    {
        if (list[i]>max)
        {
            max = list[i];
        }
    }
    return max;
}
List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
// You should get back 17 in this example
Console.WriteLine(FindMax(TestIntList2));


// 4. Square the Values

// Given a List of integers, return the List with all the values squared.

static List<int> SquareValues(List<int> list)
{
    for (int i = 0; i < list.Count; i++)
    {
        int sqVal = list[i] * list[i];
        list[i] = sqVal;
    }
        for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine(list[i]);
    }
    return list;
}
List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
// You should get back [1,4,9,16,25], think about how you will show that this worked
SquareValues(TestIntList3);

// // 5. Replace Negative Numbers with 0
// // Given an array of integers, return the array with all values below 0 replaced with 0.

static int[] NonNegatives(int[] arr)
{
    {
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            arr[i] = 0;
        }
    }
        for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
        
        
    }
    return arr;
}
}
int[] TestIntArray = new int[] {-1,2,3,-4,5};
// You should get back [0,2,3,0,5], think about how you will show that this worked
NonNegatives(TestIntArray);

// // 6. Print Dictionary

// // Given a dictionary, print the contents of the said dictionary.
static void PrintDictionary(Dictionary<string,string> dict)
{
    foreach(KeyValuePair<string,string> entry in dict)
    {
        Console.WriteLine($"{entry.Key} - {entry.Value}");
    }
}

Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);


// // 7. Find Key

// // Given a search term, return true or false whether the given term is a key in a dictionary. (Hint: figuring this one out may require some research!)

static bool FindKey(Dictionary<string,string> dict, string SearchTerm)
{
    foreach(KeyValuePair<string,string> entry in dict)
    {
        if (entry.Key == SearchTerm)
        {
            return true;
        }
    }
    return false;
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));

// // 8. Generate a Dictionary

// // Given a List of names and a List of integers, create a dictionary where the key is a name from the List of names and the value is a number from the List of numbers. Assume that the two Lists will be of the same length. Don't forget to print your results to make sure it worked.

// // Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// // {
// //	"Julie": 6,
// //	"Harold": 12,
// //	"James": 7,
// //	"Monica": 10
// // } 
static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string,int> dict = new();
    for (int i = 0; i < Names.Count; i++)
    {
        dict.Add(Names[i], Numbers[i]);
    }
    return dict;
}

static void DictPrinter(Dictionary<string,int> dict)
{
    foreach(KeyValuePair<string,int> entry in dict)
    {
        Console.WriteLine($"{entry.Key} : {entry.Value}");
    }
}
// // We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// // Your test code here

List<string> TestNames = new List<string>() {"Julie", "Harold", "James", "Monica"};
List<int> TestNumbers = new List<int>() {6,12,7,10};

Dictionary<string,int> results = GenerateDictionary(TestNames,TestNumbers);

DictPrinter(results);
