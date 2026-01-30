using System;

namespace RandomDigimon.View;

public class ArticleHelper
{
    private static string ArticleH(string? word)
    {
        if(string.IsNullOrWhiteSpace(word))
        return "a";

        char first = char.ToLower(word[0]);

        return "aeiou".Contains(first) ? "an" : "a";
    }
}
