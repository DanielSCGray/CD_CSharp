// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Console.WriteLine();

//Create a loop that prints all values from 1-255.
for (int i = 1; i < 256; i++)
{
    Console.WriteLine(i);
}
//Create a new loop that generates 5 random numbers between 10 and 20.
Random rand = new Random();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(rand.Next(10, 21));
}
//Modify the previous loop to add the random values together and print the sum after the loop finishes.
int randomSum = 0;

for (int i = 0; i < 5; i++)
{
    
    int newRand = rand.Next(10, 21);
    randomSum += newRand;
    if (i==4)
    {
        Console.WriteLine($"Total is : {randomSum}");
    }
}


// Create a new loop that prints all values from 1 to 100 that are divisible by 3 OR 5, but NOT both.

for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 != 0)
    {
        Console.WriteLine(i);
    }
    else if (i % 3 !=0 && i % 5 == 0)
    {
        Console.WriteLine(i);
    }
}

// Modify the previous loop to print "Fizz" for multiples of 3 and "Buzz" for multiples of 5.
for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 != 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 3 !=0 && i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
}
// Modify the previous loop once more to now also print "FizzBuzz" for numbers that are multiples of both 3 and 5.
for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 != 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 3 !=0 && i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (i % 3 ==0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
}
// (Optional) If you used for loops for your solutions, try doing the same with while loops. Vice versa if you used while loops!
int w = 1; 
while(w < 101)
{
    if (w % 3 == 0 && w % 5 != 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (w % 3 !=0 && w % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (w % 3 ==0 && w % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    w++;
}