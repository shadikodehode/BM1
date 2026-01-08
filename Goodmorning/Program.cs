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
    
        local.name = Console.ReadLine();
        local.name = new System.Globalization.CultureInfo("en-US", false).TextInfo.ToTitleCase(local.name.ToLower());

        local.GreetLocal();

        //Console.WriteLine("If you would like to see the current time in another country, type in the name of a country or "no" to exit the program");
        //Timezone zone = new();
    }  
    
}
