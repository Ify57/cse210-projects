using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("whats your first name?  ");
        string first_name = Console.ReadLine();
        Console.Write("Enter your Last Name? ");
        string last_name = Console.ReadLine();
        Console.WriteLine($"your name is {last_name}, {first_name} {last_name}.");
    }
}