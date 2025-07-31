// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        int age;
        
        while (true)
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out age))
            {
                if (age < 0)
                {
                    Console.WriteLine("Age cannot be negative. Try again.");
                }
                else
                {
                    break; 
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        int price;

        if (age <= 12 || age >= 65)
        {
            price = 7;
        }
        else
        {
            price = 10;
        }

        Console.WriteLine($"Your ticket price is: GHC{price}");
    }
}

