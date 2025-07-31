using System;

class Program
{
    static void Main(string[] args)
    {
        double side1, side2, side3;

        // Function to read one valid side
        double ReadSide(string sideName)
        {
            double side;
            while (true)
            {
                Console.Write($"Enter length of {sideName}: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out side) && side > 0)
                {
                    return side;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            }
        }

        // Read all three sides
        side1 = ReadSide("side 1");
        side2 = ReadSide("side 2");
        side3 = ReadSide("side 3");

        // Check triangle inequality
        bool isValidTriangle =
            (side1 + side2 > side3) &&
            (side1 + side3 > side2) &&
            (side2 + side3 > side1);

        if (!isValidTriangle)
        {
            Console.WriteLine("The lengths entered do not form a valid triangle.");
        }
        else
        {
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }
    }
}
