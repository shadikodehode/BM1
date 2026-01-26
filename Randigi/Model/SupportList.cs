using CsvHelper.Configuration.Attributes;

namespace Randigi.Model;

public record SupportList
{
  [Name("Name")]
  public string? suppName {get; set;}
  [Name("Description")]
  public string? suppDesc {get; set;}
}
