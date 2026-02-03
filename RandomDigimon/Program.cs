using RandomDigimon.Model;
using RandomDigimon.View;

namespace RandomDigimon;

class Program
{
  static void Main(string[] args)
  {
    GetRandom getRandom = new();
    var digiRandom = getRandom.GetRandomDigimon();
    var article = ArticleHelper.ArticleH(digiRandom.Atr);
   
    Console.WriteLine($"You got {article} {digiRandom.Atr} {digiRandom.Name}, its in {digiRandom.Stage} stage");
    //if stage = message and abilites get if - baby 1 move 1 support if rookie 2 abilites etc
    //if fire attribute give fire moves
  }
}

