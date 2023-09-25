// See https://aka.ms/new-console-template for more information



Console.WriteLine("Hello, World!");

bool isTrue = true;

string name = "Daniel";

char initial = 'd';

int age = 32;

double height = 6.04;


Console.WriteLine($"This is my string: {name}, this is my int: {age}, this is my boolean: {isTrue}, this is my double: {height}, and this is my char: {initial}");

Random rand = new Random();

for (int i = 0; i < 15; i++)
{
    int randomInt = rand.Next(1,11);
    Console.WriteLine($"write all : {randomInt}");
    if (randomInt == 1 || randomInt ==7)
    {
        Console.WriteLine(randomInt);
    }
}
