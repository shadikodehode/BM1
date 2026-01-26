using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using CsvHelper;
using CsvHelper.Configuration.Attributes;

namespace Randigi.Model;

public class DigimonList

{   
    
    [Name("Digimon")]
    public string? DigiName {get; set;}
    [Name("Stage")]
    public string? DigiStage {get; set;}
    [Name("Type")]
    public string? DigiType {get; set;}
    [Name("Attribute")]
    public string? DigiAtr {get; set;}
    [Name("Atk")]
    public int DigiAtk {get; set;}
    [Name("Int")]
    public int DigiInt {get; set;}
    [Name("SP")]
    public int DigiSp {get; set;}

    //error with relative path files when "right click copy relative path" simple fix to delete the first part, add double slashes
    //Randigi\Digimon CSV\DigiDB_digimonlist.csv -> Digimon CSV\\DigiDB_digimonlist.csv
    private readonly string _digiPath = "Digimon CSV\\DigiDB_digimonlist.csv";
    public void Digimons()
    {
      using var digiReader = new StreamReader(_digiPath);
      using var digiCsv = new CsvReader(digiReader, CultureInfo.InvariantCulture);

      var digimons = digiCsv.GetRecords<DigimonList>();
      //CsvHelper for easier use of csv files, I've done successful tests with streamreader and readalllines in isolation

      foreach (var digimon in digimons)
      {
        Console.WriteLine($"{digimon.DigiName}");
      }
    }
}
   