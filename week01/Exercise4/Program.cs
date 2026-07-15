using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.Write("What would you like to add");
        int input = int.Parse(Console.ReadLine());
        do
        {
            numbers.Add(input);
            
        } while (input != 0);
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}