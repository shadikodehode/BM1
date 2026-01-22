namespace Randigi.Model;

public class CsvReader
{
    string path = "DigiDB_digimonlist.csv";
    StreamReader reader = null;

    if (File.Exists(path))
    {
        
    }
    else
    {
        Console.WriteLine("File does not exist");
    }
}