using System;

namespace CoreShell
{
    class Program
    {
        static int Main(string[] args)
        {
            while(true)
            {
                Console.Write("> ");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    return 0;
                }
                else if (userInput.Length == 0)
                    continue;
                else if (userInput.ToLower() == "input")
                {
                    Console.Write("Enter a number: ");
                    string startString = Console.ReadLine();
                    int start = 0;
                    bool isInt = int.TryParse(startString, out start);
                    while (!isInt)
                    {
                        Console.Write("Enter a number: ");
                        startString = Console.ReadLine();
                        isInt = int.TryParse(startString, out start);
                    }
                    Console.Write("Result: ");
                    Console.WriteLine(start + 2);
                    Console.Write("Enter a string: ");
                    string inp = Console.ReadLine();
                    Console.WriteLine("Str result: " + inp);
                }
                else
                {
                    Console.WriteLine("Command not found");
                }
            }
        }
    }
}
