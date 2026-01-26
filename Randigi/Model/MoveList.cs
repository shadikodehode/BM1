using CsvHelper.Configuration.Attributes;

namespace Randigi.Model;

public record MoveList
//using record instead of class, seemed like a better with because it's immutable
{
  [Name("Move")]
  public string? moveName { get; set; }
  [Name("Type")]
  public string? moveType { get; set; }
  [Name("Attribute")]
  public string? moveAtr { get; set; }
  [Name("Description")]
  public string? moveDesc { get; set; }
}
