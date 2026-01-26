using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using CsvHelper;
using CsvHelper.Configuration.Attributes;

namespace Randigi.Model;

public class DigimonList

{   
    
    [Name("Digimon")]
    public string? digiName {get; set;}
    [Name("Stage")]
    public string? digiStage {get; set;}
    [Name("Type")]
    public string? digiType {get; set;}
    [Name("Attribute")]
    public string? digiAtr {get; set;}
    [Name("Atk")]
    public int digiAtk {get; set;}
    [Name("Int")]
    public int digiInt {get; set;}
    [Name("SP")]
    public int digiSp {get; set;}

    //error with relative path files when "right click copy relative path" simple fix to delete the first part, add double slashes
    //Randigi\Digimon CSV\DigiDB_digimonlist.csv -> Digimon CSV\\DigiDB_digimonlist.csv
    private readonly string _digiPath = "Digimon CSV\\DigiDB_digimonlist.csv";
    public void DigiTest()
    {
      using var digiReader = new StreamReader(_digiPath);
      using var digiCSV = new CsvReader(digiReader, CultureInfo.InvariantCulture);

      var digimons = digiCSV.GetRecords<DigimonList>();

      foreach (var digimon in digimons)
      {
        Console.WriteLine($"{digimon.digiName}");
      }
    }
}
   