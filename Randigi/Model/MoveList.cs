using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using CsvHelper;
using CsvHelper.Configuration.Attributes;

namespace Randigi.Model;

public record MoveList
//using record instead of class, seemed like a better with because it's immutable
{
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
}
