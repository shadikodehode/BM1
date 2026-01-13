using System;
using System.Linq;

namespace Calc;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is a calculatorTM");
        bool isRunning = true;
        string input = Console.ReadLine();

        while (isRunning)
        {
            if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid, please enter a valid equation");
            break;
        }
        else
        
        }
    }
}