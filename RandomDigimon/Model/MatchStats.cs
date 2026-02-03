// using System;

// namespace RandomDigimon.Model;

// public class MatchStats
// {
//     public DigimonReader StatCheck()
//     {
//         GetRandom getRandom = new();
//         var random = getRandom.GetRandomDigimon();
//         var reader = new DigimonReader();
//         var moves = reader.MoveList();
//         var matchingMove = moves
//             .Where(m => m.MoveAtr == random.Atr)
//             .ToList();

//         if(matchingMove.Count == 0)
//             throw new Exception("no moves found");

//         return matchingMove[Random.Shared.Next(matchingMove.Count)];
//     }
// }

///unknown error, implementing this later