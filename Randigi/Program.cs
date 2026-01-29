
using System.Globalization;
using CsvHelper.Configuration.Attributes;
using Randigi.Model;
using CsvHelper;
using CsvHelper.Configuration;
using CsvReader = CsvHelper.CsvReader;
using System.Linq;

namespace Randigi;
class Program
{
    static void Main(string[] args)
    {
        DigimonList digiList = new();
        digiList.Digimons();

        // MoveList moveList = new();
        // moveList.Moves();

        // SupportList supportList = new();
        // supportList.Supports();
    }
}
