using System;
using System.Linq;

namespace Calc;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is a calculatorTM"); 
        //Welcoming message
        string? input = Console.ReadLine(); 
        //User input
        string[] tokens = input.Split(' ');
        //Using space for spliting to tokenize the input
       
        
        // foreach (string token in tokens)
        // {
        //     Console.WriteLine(token);
        // }
        //tokenize test:success

        string _num1 = tokens[0];
        string _op = tokens[1];
        string _num2 = tokens[2];
        int num1 = Convert.ToInt32(_num1);
        double num1D = Convert.ToDouble(_num1);
        int num2 = Convert.ToInt32(_num2);
        double num2D = Convert.ToDouble(_num2);
        string op = _op;
        //parsing the input

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
        Calculation sum = new();
        int totalAdd = sum.Add(num1, num2);
        // double totalAddD = sum.Add(num1D, num2D);
        int totalSub = sum.Sub(num1, num2);
        // double totalSubD = sum.Sub(num1, num2);
        int totalMul = sum.Mul(num1, num2);
        // double totalMulD = sum.Mul(num1, num2);
        double totalDiv = sum.Div(num1, num2);
        // double totalDivD = sum.Div(num1, num2);

        // bool isIntFirst = int.TryParse(_num1, out num1);
        // bool isIntSecond = int.TryParse(_num2, out num2);

        Printer print = new();

        if(op == "+")
        {
            print.Print(totalAdd.ToString());
                return;
        }
        if(op == "-")
        {
            print.Print(totalSub.ToString());
        }
        if(op == "*")
        {
            print.Print(totalMul.ToString());
        }
        if(op == "/")
        {
            print.Print(totalDiv.ToString());
        }
    }
}