using System;

class Program
{
    static void Main(string[] args)
    {
        Random com_guess = new Random();
        int rand_number = com_guess.Next(1,100);
        // string str = rand_number.ToString();

        // Console.Write($"{rand_number}");
        Console.Write("whats your guess? ");
        string read_guess = Console.ReadLine();
        int guess = int.Parse(read_guess);
        while (guess != rand_number)
        {
            int guess_number = rand_number;
            Console.WriteLine($"computers guess { guess_number}");
            Console.Write("whats your guess? ");
            string next_guess = Console.ReadLine();    
            int next_guess_converted = int.Parse(next_guess);
            if (next_guess_converted == guess_number)
            {
                Console.WriteLine("Congratulation you guessed right");
                break;
            }
            else if(next_guess_converted > guess_number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }                     
        }


    }
}