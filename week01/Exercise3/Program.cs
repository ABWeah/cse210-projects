using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine();

        // int magicNumber = 8;
        //string guess = "";

    //Ask the user to enter the magic number
        // Console.Write("What is the magic number? ");
        // string number = Console.ReadLine();
        // int magicNumber = int.Parse(number);

    // Let the computer generate a random number as the magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

    // Ask the user to guess the magic number
        // Console.Write("What is your guess? ");
        // string guess = Console.ReadLine();
        // int userNumber = int.Parse(guess);

        int guess = -1;
        int attempts = 1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            
            if (guess > magicNumber)
            {
                Console.WriteLine("Your guess is Higher");
                attempts++;
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Your guess is Lower");
                attempts++;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"CONGRATULATIONS! {magicNumber} was the number. You attempted {attempts} times.");
                attempts++;
            }
        }    
    }
}