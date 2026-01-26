using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using CsvHelper;
using CsvHelper.Configuration.Attributes;

namespace Randigi.Model;

public record DigimonList
//using record instead of class, seemed like a better with because it's immutable
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

  [Name("Move")]
  public string? MoveName { get; set; }
  [Name("Type")]
  public string? MoveType { get; set; }
  [Name("Attribute")]
  public string? MoveAtr { get; set; }
  [Name("Description")]
  public string? MoveDesc { get; set; }

   private readonly string _movePath = "Digimon CSV\\DigiDB_movelist.csv";
    public void Moves()
    {
      using var moveReader = new StreamReader(_movePath);
      using var moveCsv = new CsvReader(moveReader, CultureInfo.InvariantCulture);

      var moves = moveCsv.GetRecords<MoveList>();

      foreach (var skill in moves)
      {
        Console.WriteLine($"{skill.MoveName}");
      }
    }

   [Name("Name")]
  public string? SuppName {get; set;}
  [Name("Description")]
  public string? SuppDesc {get; set;}

   private readonly string _suppPath = "Digimon CSV\\DigiDB_supportlist.csv";
    public void Supports()
    {
      using var suppReader = new StreamReader(_suppPath);
      using var suppCsv = new CsvReader(suppReader, CultureInfo.InvariantCulture);

      var support = suppCsv.GetRecords<SupportList>();

      foreach (var item in support)
      {
        Console.WriteLine($"{item.SuppName}");
      }
    }
}
