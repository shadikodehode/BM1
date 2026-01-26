
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
        DigimonList digiList = new();
        digiList.Digimons();
        digiList.Moves();
        digiList.Supports();

    }
}
