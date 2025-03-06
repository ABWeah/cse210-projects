using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int>numbers = new List<int>();

        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Add a number to the list. 0 when finished: ");

            string response = Console.ReadLine();
            userNumber = int.Parse(response);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Compute the sum of the number in the list

        int sum = 0;
        foreach(int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"Th sum is: {sum}");

        //Compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        // Find the maximum number in the list.

        int max = numbers[0];

        foreach(int number in numbers)
        {
            if(number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The maximum number is {max}");

        // Find the minimum number in the list
        int min = numbers[0];

        foreach (int number in numbers)
        {
            if(number < min)
            {
                min = number;
            }
        }
        Console.WriteLine($"The minimum number is {min}");
        
    }
}