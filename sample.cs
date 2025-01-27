using System;
using System.Collections.Generic;

namespace SonarQubeSample
{
    public class Program
    {
        // Unused variable (SonarQube should flag this)
        private static string unusedVariable = "I am not used";

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the SonarQube Analysis Example!");

            // Hardcoded value issue (SonarQube should flag this)
            int result = AddNumbers(10, 20);
            Console.WriteLine($"The sum is: {result}");

            // Potential null reference issue
            string message = GetMessage(null);
            Console.WriteLine(message);

            // Poor exception handling
            try
            {
                int divisionResult = DivideNumbers(10, 0);
                Console.WriteLine($"Division result: {divisionResult}");
            }
            catch
            {
                Console.WriteLine("An error occurred.");
            }

            // Dead code (never executed)
            if (false)
            {
                Console.WriteLine("This will never be printed.");
            }
        }

        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public static string GetMessage(string name)
        {
            return $"Hello, {name ?? "Guest"}!";
        }

        public static int DivideNumbers(int a, int b)
        {
            return a / b; // SonarQube should flag division by zero
        }
    }
}
