using System;

namespace RandomDigimon.View;

/// <summary>
/// An article helper to put a or an depending on if the pokemons name starts with a vowel or not 
/// A simple binary method that works for general names, but would be too simple for a wider use case, 
/// i.e if a sound starts with a vowel but is written with consonant
/// </summary>
public class ArticleHelper
{
    public static string ArticleH(string? word)
    {
        if(string.IsNullOrWhiteSpace(word))
        return "a";

        char first = char.ToLower(word[0]);

        return "aeiou".Contains(first) ? "an" : "a"; // "ifTrue" : "ifFalse", this is just a what if statement that is compacted
    }
}
