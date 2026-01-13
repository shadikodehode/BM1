namespace Calc;

class Program
{
    static void Main(string[] args)
    {
        Callculator calc = new();
        Console.WriteLine("This is a calculatorTM");
        double total = calc.Sum();
    }
}
public class Callculator
{
    public double Sum(params double[] numbers)
    {
        return numbers.Sum();
    }
}
