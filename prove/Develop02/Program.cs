using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Menu.ShowMenu();
        bool exit = false;
        Random random = new Random();

        while(!exit)
        {
            Console.Write("Enter your choice; ");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Entry entry = new Entry();

                    Console.WriteLine(entry.Prompt);

                    Console.Write("Enter your response: ");
                    string response = Console.ReadLine();

                    journal.AddEntry(entry.Prompt, response, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;
                case 4:
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
                case 5:
                    exit = true;
                    break;
            }
        }
    }
}