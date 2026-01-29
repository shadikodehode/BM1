using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using RandomDigimon;

namespace RandomDigimon.Model;

public class DigimonReader
{
    public string? Name {get; set;}
    public string? Stage {get; set;}
    public string? Type {get; set;}
    public string? Atr {get; set;}
    public string? Atk {get; set;}
    public string? Int {get; set;}
    public string? Sp {get; set;}

    private readonly string _digimonPath = "Digimon CSV\\DigiDB_digimonlist.csv";
    // private readonly string _movePath = "Digimon CSV\\DigiDB_movelist.csv";
    // private readonly string _supportPath = "Digimon CSV\\DigiDB_supportlist.csv";

    private static readonly Random _random = new Random();
    public  List<DigimonReader> DigimonList()
    {
       
        var digimons = new List<DigimonReader>();

        var digiList = File.ReadAllLines(_digimonPath);
            foreach(var lines in digiList.Skip(1))
            {
                var column = lines.Split(',');
                digimons.Add(
                    new DigimonReader
                    {
                        Name = column[1],
                        Stage = column[3],
                        Type = column[4],
                        Atr = column[5],
                        Sp = column[9],
                        Atk = column[10],
                        Int = column[12],
                    }
                            );
                
            }
        return digimons;
    }

    public DigimonReader GetRandomDigimon()
    {
       var reader = new DigimonReader();
       var digimons = reader.DigimonList();
       var randomDigimon = digimons[Random.Shared.Next(digimons.Count)];
       return randomDigimon;
    }
}
