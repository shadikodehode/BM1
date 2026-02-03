using System;

namespace RandomDigimon.Model;
/// <summary>
/// Gets one random digimon from the list
/// </summary>
public class GetRandom
{
    public  DigimonReader GetRandomDigimon()
    {
        var reader = new DigimonReader();
        var digimon = reader.DigimonList();
        var randomDigimon = digimon[Random.Shared.Next(digimon.Count)];
        return randomDigimon;
    }
}
