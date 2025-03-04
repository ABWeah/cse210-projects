using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.Write("what is your last name? ");
        string last_name = Console.ReadLine();

        Console.Write("what is your first name? ");
        string first_name = Console.ReadLine();
        
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}