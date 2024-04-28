using System;

class Program
{
    static void Main(string[] args)
    {
        //Part 1 and 2
        // Console.Write("What is the magic number?");
        //int magicNumber = int.Parse(Console.ReadLine());

        //Part 3
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess!= magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Too high!");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Too low!");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        }

    }
}