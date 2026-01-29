using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using CsvHelper;
using CsvHelper.Configuration.Attributes;
using System.Linq;

namespace Randigi.Model;

public record DigimonList

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

    private static Random _random = new Random();

    //error with relative path files when "right click copy relative path" simple fix to delete the first part, add double slashes
    //Randigi\Digimon CSV\DigiDB_digimonlist.csv -> Digimon CSV\\DigiDB_digimonlist.csv
    public readonly string _digiPath = "Digimon CSV\\DigiDB_digimonlist.csv";
    public void Digimons()
    {
      using var digiReader = new StreamReader(_digiPath);
      using var digiReaderCsv = new CsvReader(digiReader, CultureInfo.InvariantCulture);
      
      using var digiWriter = new StreamWriter(_digiPath);
      using var digiWriterCsv = new CsvWriter(digiWriter, CultureInfo.InvariantCulture);
    

      var digimons = digiReaderCsv.GetRecords<DigimonList>().ToList();
      
      //CsvHelper for easier use of csv files, I've done successful tests with streamreader and readalllines in isolation   


    }
}
   