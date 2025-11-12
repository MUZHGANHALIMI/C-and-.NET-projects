using System;

namespace MathOperationApp
{
    // This class contains mathematical operations
    public class MathOperations
    {
        // This method takes two integers as parameters
        // It performs a math operation (multiplication) on the first integer
        // and displays the second integer on the screen
        public void PerformOperation(int number1, int number2)
        {
            // Multiply the first integer by 2 and store the result
            int result = number1 * 2;

            // Display the results to the console
            Console.WriteLine($"The result of doubling {number1} is: {result}");
            Console.WriteLine($"The second number you entered is: {number2}");
        }
    }
}
