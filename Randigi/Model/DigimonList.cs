using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using CsvHelper;

namespace Randigi.Model;

public class DigimonList
{   
    public string? Digimon {get; set;}
    public string? Stage {get; set;}
    public string? Type {get; set;}
    public string? Attribute {get; set;}
    public int ATK {get; set;}
    public int INT {get; set;}
    public int SP {get; set;}
}
   