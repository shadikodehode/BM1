using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Calc;

class Program
{
    static void Main(string[] args)
    {
        //Welcoming message
        //added colors throughout to make it look nicer
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("This is a simple calculator that uses one line of input"); 
        Console.WriteLine("input a number then operator and another number e.g. '2 + 5' spaces between number and operator is mandatory");
        Console.WriteLine("this only supports whole numbers and simple calculations with '+' '-' '*' '/'");
        Console.WriteLine("to exit the program, input: 'exit', 'c' or 'x'");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Input your calculation:");
        Console.ResetColor();
        
        
        bool isRunning = true;

        // did a couple of tests here before taking it into the while loop

        // foreach (string token in tokens)
        // {
        //     Console.WriteLine(token);
        // }
        //tokenize test:success

        // Console.WriteLine(num1);
        // Console.WriteLine(op);
        // Console.WriteLine(num2);
        //tokenize test:success

        // if(op == "+")
        // {
        //     Console.WriteLine($"Success, operator was {op}");
        // }
        // else
        // {
        //     Console.WriteLine("Failure");
        // }return;
        //Test to get the operator: success

        //I tried to make it so you could input numbers with decimals but I hit a wall
        // double totalAddD = sum.Add(num1D, num2D);
        // double totalSubD = sum.Sub(num1, num2);
        // double totalMulD = sum.Mul(num1, num2);
        // double totalDivD = sum.Div(num1, num2);
        // bool isIntFirst = int.TryParse(_num1, out num1);
        // bool isIntSecond = int.TryParse(_num2, out num2);
        //part of my decimal/double test: failure

        Printer print = new();
        //imports the custom Printer class 
        
        Calculation sum = new();
        //imports the custom Calculation class

        while (isRunning)
        {
            
            string? input = Console.ReadLine();
            //user input
            string[] tokens = input?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? throw new ArgumentNullException(input);
            int tokenC = tokens.Length;
           
            //Using space for spliting to tokenize the input and removes any excess spaces to handle errors
            
            if (input == "exit" || input == "c" || input == "x")
            {
                Console.WriteLine("Exiting porgram...");
                isRunning = false;
                return;
            } 
            if(tokenC == 3 && input.Contains('+') && input.Contains(' ')
            || tokenC == 3 && input.Contains('-') && input.Contains(' ')  
            || tokenC == 3 && input.Contains('*') && input.Contains(' ')  
            || tokenC == 3 && input.Contains('/') && input.Contains(' '))
            //Set a condition for parsing, or else if the input didn't contain 3 inputs it would give an array out of bounds error
            //I asume there is a better way to do this but this is as far as I got with my current knowledge 
            //One thing I couldd't figure out to integrate in a nice way was to check for number 1 and 2 containing int, right now there is an error if you do 's + d' e.g.
            {
                {
                    string _num1 = tokens[0];
                    string _num2 = tokens[2];
                    int num1 = Convert.ToInt32(_num1);
                    int num2 = Convert.ToInt32(_num2);
                    //parsing the input

                    if(input.Contains('+'))
                    {
                        int totalAdd = sum.Add(num1, num2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        print.Print(totalAdd.ToString()); 
                        Console.ResetColor();
                        // Console.WriteLine($"{totalAdd}");
                        //calls the Calculations and Printer classes
                    }

                    if(input.Contains('-'))
                    {
                        int totalSub = sum.Sub(num1, num2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        print.Print(totalSub.ToString()); 
                        Console.ResetColor();
                        
                    }

                    if(input.Contains('*'))
                    {
                        int totalMul = sum.Mul(num1, num2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        print.Print(totalMul.ToString()); 
                        Console.ResetColor();
                    
                    }

                    if(input.Contains('/'))
                    {
                        if(num2 != 0)
                        //Zero check for divison
                        {
                            double totalDiv = sum.Div(num1, num2);
                            Console.ForegroundColor = ConsoleColor.Green;
                            print.Print(totalDiv.ToString()); 
                            Console.ResetColor();
                        }           
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid, cannot divide by zero");
                            Console.ResetColor();
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Input your calculation:");
                    Console.ResetColor();                
                }
            }
            
            else 
            {   
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Input your calculation:");
                Console.ResetColor();
            }
        }
    }
}