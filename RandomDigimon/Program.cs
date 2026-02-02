using RandomDigimon.Model;
using RandomDigimon.View;

namespace RandomDigimon;

class Program
{

  static void Main(string[] args)
  {
    DigimonReader digiread = new();
    var digiRandom = digiread.GetRandomDigimon();
    var article = ArticleHelper.ArticleH(digiRandom.Atr);
   
    Console.WriteLine($"You got {article} {digiRandom.Atr} {digiRandom.Name}, and is a {digiRandom.Stage}");
  }

}

