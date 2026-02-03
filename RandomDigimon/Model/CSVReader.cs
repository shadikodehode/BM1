using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using RandomDigimon;

namespace RandomDigimon.Model;

public class DigimonReader
{  
    //sets the properties for digimonlistDB 
    public string? Name {get; set;}
    public string? Stage {get; set;}
    public string? Type {get; set;}
    public string? Atr {get; set;}
    public string? Atk {get; set;}
    public string? Int {get; set;}
    public string? Sp {get; set;}

    //sets the properties for movelistDB 
    public string? Move {get; set;}
    public string? MoveSp {get; set;}
    public string? MoveType {get; set;}
    public string? MoveAtr {get; set;}
    public string? MoveDesc {get; set;}

    //sets the properties for supportlistDB 
    public string? SupportName {get; set;}
    public string?  supportDesc {get; set;}

    private readonly string _digimonPath = "Digimon CSV\\DigiDB_digimonlist.csv";
    private readonly string _movePath = "Digimon CSV\\DigiDB_movelist.csv";
    private readonly string _supportPath = "Digimon CSV\\DigiDB_supportlist.csv";

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
                        Stage = column[2],
                        Type = column[3],
                        Atr = column[4],
                        Sp = column[8],
                    });
            }
            return digimons;
    }

    public  List<DigimonReader> MoveList()
    {
       
        var moves = new List<DigimonReader>();

        var moveList = File.ReadAllLines(_movePath);
            foreach(var lines in moveList.Skip(1))
            {
                var column = lines.Split(',');
                moves.Add(
                    new DigimonReader
                    {
                        Move = column[1],
                        MoveSp = column[2],
                        MoveType = column[3],
                        MoveAtr = column[4],
                        MoveDesc = column[8],
                    });
            }
            return moves;
    }
    public  List<DigimonReader> SupportList()
    {
       
        var supports = new List<DigimonReader>();

        var supportList = File.ReadAllLines(_supportPath);
            foreach(var lines in supportList.Skip(1))
            {
                var column = lines.Split(',');
                supports.Add(
                    new DigimonReader
                    {
                        SupportName = column[1],
                        supportDesc = column[2],
                    });
            }
            return supports;
    }
}
