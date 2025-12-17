Console.WriteLine("this is a simple calculator, please select first input:");
double num1 = Convert.ToInt32(Console.ReadLine());
//creates the starting message, and input for the first number

Console.WriteLine("Input the operator");
string? op = Console.ReadLine();
//input for the operator

Console.WriteLine("second input:");
double num2 = Convert.ToInt32(Console.ReadLine());
// input for the second number

if (op == "+") //checks if the operator is set to the char for addition
{
    double add = (int)num1 + (int)num2; // runs method for addition
    Console.WriteLine(num1 + " " + "+" + " " + num2 + " " + "=" + " " + add); // writes out the answe in full
}
if (op == "-")
{
    double sub = (int)num1 - (int)num2;
    Console.WriteLine(num1 + " " + "-" + " " + num2 + " " + "=" + " " + sub);
}
if (op == "*")
{
    double mul = (int)num1 * (int)num2;
    Console.WriteLine(num1 + " " + "*" + " " + num2 + " " + "=" + " " + mul);
}
if (op == "/")
{
    if (num2 == 0) //makes sure that division by 0 is not possible by giving an error message
    {
        Console.WriteLine("Error, cannot divide by 0");
    } 
    else
    {
    double div = num1 / num2;
    Console.WriteLine(num1 + " " + "/" + " " + num2 + " " + "=" + " " + div);
    }
}