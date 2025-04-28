using System;

class Program
{
    static void Main()
    {
        // Display a welcome message and instruction to the user.
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt user for the package weight and store the value as a double
        Console.WriteLine("Please enter the package weight:");
        double weight = double.Parse(Console.ReadLine());

        // Check if the weight exceeds 50 and show an error message if so
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Exit the program if the weight is too heavy
        }

        // Prompt user for the package width
        Console.WriteLine("Please enter the package width:");
        double width = double.Parse(Console.ReadLine());

        // Prompt user for the package height
        Console.WriteLine("Please enter the package height:");
        double height = double.Parse(Console.ReadLine());

        // Prompt user for the package length
        Console.WriteLine("Please enter the package length:");
        double length = double.Parse(Console.ReadLine());

        // Check if the total dimensions exceed 50 and show an error message if so
        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Exit the program if the total dimensions are too large
        }

        // Calculate the shipping quote by multiplying dimensions and weight, then dividing by 100
        double quote = (width * height * length * weight) / 100;

        // Display the shipping quote to the user, formatted to 2 decimal places
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

        // Thank the user for using the service
        Console.WriteLine("Thank you!");
    }
}

