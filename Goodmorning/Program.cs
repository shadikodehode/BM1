using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Goodmorning;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please type in your name"); //startmessage
        Local local = new();
        local.morning = new TimeOnly(6, 12);
        local.afternoon = new TimeOnly(12, 18);
        local.evening = new TimeOnly(18, 24);  
        local.night = new TimeOnly(00, 6);      
        local.currentTime = TimeOnly.FromDateTime(DateTime.Now);
        local.timeLocal = DateTime.Now;
        // setting the variables from the 'local' class

        local.name = Console.ReadLine() ?? throw new ArgumentNullException(nameof(local.name)); //unsure about the null-check here, seemed to work
        local.name = new CultureInfo("nb-NO").TextInfo.ToTitleCase(local.name.ToLower()); //capitalizes the first letter of the name
        
        local.GreetLocal(); //gets the message output
    }  
}
