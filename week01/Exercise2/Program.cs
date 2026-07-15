using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is your grade? ");
        char letter;
        string grade = Console.ReadLine();
        int grade_new = int.Parse(grade);
        if (grade_new >= 90)
        {
            letter = 'A';
            Console.Write($"{letter}");   
        }
        else if (grade_new >= 80)
        {
            letter = 'B';
            Console.Write($"{letter}");  
        }
        else if (grade_new >= 70)
        {
            letter = 'C';
            Console.Write($"{letter}"); 
        }
        else if (grade_new >= 60)
        {
            letter = 'D';
            Console.Write($"{letter}");   
        }
        else
        {
            letter = 'F';
            Console.WriteLine($"{letter}\nyou failed this time try again");
            
        }
        if (grade_new >= 70)
        {
            Console.WriteLine("\ncongratulation you passed");   
        }


    }
}