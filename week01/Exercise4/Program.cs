using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.Write("What would you like to add");
        int input = int.Parse(Console.ReadLine());
        numbers.Add(input);
        Console.WriteLine(input);

        while (input != 0)
        {
            
            Console.Write("What would you like to add again?");
            int input2 = int.Parse(Console.ReadLine());
            numbers.Add(input2);
            if(input2 == 0)
            {
                break;
            }          
        }
        numbers.Remove(0);
        int sumed = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();
        Console.WriteLine($"The sum is { sumed}");
        Console.WriteLine($"The Average is { average}");
        Console.WriteLine($"The max number is { max}");
       
    }
}