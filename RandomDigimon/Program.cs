using RandomDigimon.Model;

namespace RandomDigimon;

class Program
{

  static void Main(string[] args)
  {
   DigimonReader digiread = new();
   digiread.GetRandomDigimon();
  }

}

