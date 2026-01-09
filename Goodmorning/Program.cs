using System.Security.Cryptography.X509Certificates;

namespace Goodmorning;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please type in your name");
        Local local = new();
        local.morning = new TimeOnly(6, 12);
        local.afternoon = new TimeOnly(12, 18);
        local.evening = new TimeOnly(18, 24);  
        local.night = new TimeOnly(00, 6);      
        local.currentTime = TimeOnly.FromDateTime(DateTime.Now);
        local.timeLocal = DateTime.Now;
    
        local.name = Console.ReadLine() ?? throw new ArgumentNullException(nameof(local.name)); //usikker på null checken her
        local.name = new System.Globalization.CultureInfo("nb-NO", false).TextInfo.ToTitleCase(local.name.ToLower());
        local.GreetLocal();
    }  
}
