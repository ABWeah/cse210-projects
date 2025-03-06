using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string userGradePoint = Console.ReadLine();
        
        int userGrade = int.Parse (userGradePoint);

        string letter = "";
        string sign = ""; 

        if (userGrade >= 90)
        {
            letter = "an 'A";

            if (userGrade <= 93)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
            // Console.WriteLine("PASSED. You scored an 'A'.");
        }
        else if (userGrade >= 80)
        {
            letter = "a 'B";
             if (userGrade >= 87)
            {
                sign = "+";
            }
            else if (userGrade <= 83)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
            // Console.WriteLine("PASSED! You scored a 'B'. ");
        }
        else if (userGrade >= 70)
        {
            letter = "a 'C";
             if (userGrade >= 77)
            {
                sign = "+";
            }
            else if (userGrade <= 73)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
            // Console.WriteLine("PASSED! You scored a 'C'.");
        }
        else if (userGrade >= 60)
        {
            letter = "a 'D";
             if (userGrade >= 67)
            {
                sign = "+";
            }
            else if (userGrade <= 63)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
            // Console.WriteLine("Your grade is 'D'. You could better if you persist.");
        }
        else
        {
            letter = "an 'F";
            //Console.WriteLine("Your grade is 'F'. You could do better if you persist.");
        }

        if (userGrade >= 70)
        {
            Console.WriteLine($"CONGRATULATIONS. You PASSED the course with {letter}{sign}' gradepoint.");
        } 
        else
        {
            Console.WriteLine($"SORRY! You could do better. You scored '{userGrade}' which is {letter}{sign}' gradepoint.");
        }

    }
}