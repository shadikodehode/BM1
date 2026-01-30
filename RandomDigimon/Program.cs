using RandomDigimon.Model;
using RandomDigimon.View;

namespace RandomDigimon;

class Program
{

  static void Main(string[] args)
  {
   DigimonReader digiread = new();
   var digiRandom = digiread.GetRandomDigimon();

   Console.WriteLine($"Your digimon is {digiRandom.Name}! it is a {digiRandom.Stage}, of the attribute {digiRandom.Atr}"); //change structure
   Console.WriteLine($"You got a {digiRandom.Atr} {digiRandom.Name}, it is a {digiRandom.Stage}");
  }

}

