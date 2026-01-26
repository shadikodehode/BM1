using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using CsvHelper;
using CsvHelper.Configuration.Attributes;

namespace Randigi.Model;

public record SupportList
{
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
