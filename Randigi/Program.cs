
using System.Globalization;
using CsvHelper.Configuration.Attributes;
using Randigi.Model;
using CsvHelper;
using CsvHelper.Configuration;
using CsvReader = CsvHelper.CsvReader;

namespace Randigi;
class Program
{
    static void Main(string[] args)
    {
        //CsvHelper for easier use of csv files, I've done successful tests with streamreader and readalllines in isolation

        DigimonList digilist = new();
        digilist.DigiTest();
    }
}
