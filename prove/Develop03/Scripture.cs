using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public ScriptureReference Reference { get; }
    private string[] Words { get; }
    private HashSet<int> HiddenIndices { get; } = new();

    public Scripture(string text, ScriptureReference reference)
    {
        Reference = reference;
        Words = text.Split(' ');
    }

    public void HideRandomWord()
    {
        if (HiddenIndices.Count < Words.Length)
        {
            var rnd = new Random();
            int index;
            do
            {
                index = rnd.Next(Words.Length);
            } while (HiddenIndices.Contains(index));
            
            HiddenIndices.Add(index);
        }
    }

    public override string ToString()
    {
        return $"{Reference} - " + 
               string.Join(" ", Words.Select((word, index) => HiddenIndices.Contains(index) ? "____" : word));
    }
}
