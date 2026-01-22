
namespace Randigi;
class Program
{
    static void Main(string[] args)
    {
        string path = "DigiDB_digimonlist.csv";
    StreamReader reader = null;

    if (File.Exists(path))
    {
        reader = new StreamReader(File.OpenRead(path));
    }
    else
    {
        Console.WriteLine("File does not exist");
        //var data = line.split(',')
        //if(!File.Exists(path)) return default;
        //foreach(var line in File.Readline(path))
        //{ if(t.tryparse(line.Split(',')[0], out T result)) {return results;} } return default;
    }
    }
}
