using System;

class Program
{
    static void Main(string[] args)
    {
        int grade;
        while (true)
        {
            Console.Write("Enter your numerical grade (0 - 100): ");
            string input = Console.ReadLine();

            //To Check if input is a valid integer
            if (int.TryParse(input, out grade))
            {
                // Check if grade is in the correct range
                if (grade >= 0 && grade <= 100)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Grade must be between 0 and 100. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        // Determine letter grade
        string letterGrade;

        if (grade >= 90)
            letterGrade = "A";
        else if (grade >= 80)
            letterGrade = "B";
        else if (grade >= 70)
            letterGrade = "C";
        else if (grade >= 60)
            letterGrade = "D";
        else
            letterGrade = "F";

        Console.WriteLine($"Your letter grade is: {letterGrade}");
    }
}
