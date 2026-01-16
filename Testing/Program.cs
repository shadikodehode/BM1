  string? input = Console.ReadLine(); 
        string[] tokens = input.Split(' ');
        
//         foreach(string token in tokens)
// {
//     Console.WriteLine(token);
// }

// string _num1 = tokens[0];
// string _num2 = tokens[2];
// string _op = tokens[1];
// double num1 = Convert.ToDouble(_num1);
string lastT = null;
foreach(var token in tokens)
{
    lastT = token;
}
List<string> _token = new();
foreach (var token in tokens)
{
    _token.Add(token);
}
Console.WriteLine(_token);