using System;

namespace Calculator
{
    // A class that contains a static method to divide 2 floating point numbers
    public static class Calculator
    {
        // A static method that takes 2 double parameters and returns their quotient
        public static double Divide(double num1, double num2)
        {
            // Check if the second number is 0
            if (num2 == 0)
            {
                // Throw an ArgumentException if so, since division by 0 is undefined
                throw new ArgumentException("Cannot divide by 0");
            }
            // Return the result of dividing the first number by the second number
            return num1 / num2;
        }
    }

    // A class to test the Calculator class using user inputs and exception handling
    public static class TestCalculator
    {
        public static void Main(string[] args)
        {
            try
            {
                // Prompt the user to enter 2 numbers
                Console.WriteLine("Enter the first number:");
                string? input1 = Console.ReadLine();
                Console.WriteLine("Enter the second number:");
                string? input2 = Console.ReadLine();

                // Parse the inputs to double using Double.Parse, catching any FormatException or OverflowException if the inputs are invalid
                double num1 = Double.Parse(input1!); // Using the null-forgiving operator
                double num2 = Double.Parse(input2 ?? "0"); // Using the null-coalescing operator

                // Call the static method to divide the numbers and display the result
                double result = Calculator.Divide(num1, num2);
                Console.WriteLine($"The result of dividing {num1} by {num2} is {result}");
            }
            catch (FormatException e)
            {
                // Catch any FormatException and print its message
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                // Catch any OverflowException and print its message
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                // Catch any ArgumentException and print its message
                Console.WriteLine(e.Message);
            }
        }
    }
}
