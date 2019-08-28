using System;

namespace ConsoleAppTFS1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Can you tell me your name,pls?");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Hello "+ name);
            Console.WriteLine("Please enter to close...");
            Console.ReadLine();
        }
    }
}
