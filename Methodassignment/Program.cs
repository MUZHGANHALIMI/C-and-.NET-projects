using System;

namespace MathOperationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate (create) an object of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method by passing in two integers (positional arguments)
            mathOps.PerformOperation(10, 5);

            // Call the method again, this time specifying parameters by name
            mathOps.PerformOperation(number1: 20, number2: 8);

            // Wait for user input before closing the console
            Console.ReadLine();
        }
    }
}
