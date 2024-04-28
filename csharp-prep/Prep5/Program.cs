using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PrompUserName();
        int userNumber = PrompUserNumber();

        int squaredNumber = SquareNumber (userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Squared Number Calculator!");
    }

    static string PrompUserName()
    {
        Console.WriteLine("What is your name ?");
        string name = Console.ReadLine();
        return name;
    }

    static int PrompUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine(userName + ", your number squared is: " + squaredNumber);
    }
}