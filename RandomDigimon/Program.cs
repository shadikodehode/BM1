using RandomDigimon.Model;

namespace RandomDigimon;

class Program
{

  static void Main(string[] args)
  {
   DigimonReader digiread = new();
   var digiList = digiread.DigimonList();
   var digiRandom = digiread.GetRandomDigimon();

   Console.WriteLine($"Your digimon is {digiRandom.Name}! it is a {digiRandom.Stage}, of the attribute {digiRandom.Atr}"); //change structure
  }

}

