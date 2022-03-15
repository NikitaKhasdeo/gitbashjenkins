using System;

namespace MethodBasics
{
    internal class MyProgram
    {
        static void Main(string[] args)
        {
            // Call CalculateTotalAndAverage
            MyProgram.CalculateTotalAndAverage(56, 89, 90);
            MyProgram.CalculateTotalAndAverage(90, 59, 70);

            Console.WriteLine();
            Console.WriteLine("Hello World!");
            Console.WriteLine(); // New Line
            Console.WriteLine("Hello World!");
            Console.WriteLine(); // New Line
            Console.Write("Hello");
            Console.Write(" World");

            Console.WriteLine();

            Console.WriteLine(Math.Sqrt(90));
            
        }

        // Method that accepts three parameters. 
        static void CalculateTotalAndAverage(int m1, int m2, int m3)
       {
           
            int total = m1 + m2 + m3; // addition operation

            // Calculate Avg
            float avg = total / 3f;

            Console.WriteLine("Total: " + total);
            Console.WriteLine("Average: " + avg);
            // + is called string concatenation
       }
    }
}
