using System;

namespace MyFirstCSharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.PrintData(100);
            System.Console.Write(1200);
        }
    }

    // Create your own Console class
    class Console 
    {
        // Method to print data to Console window
        public static void PrintData(int n)
        {
            System.Console.WriteLine(n);
        }

        public static void WriteLine(string s)
        {
            System.Console.WriteLine(s);
        }
    }



}
