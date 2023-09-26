public class ScriptureReference
{
    public string Book { get; }
    public int Chapter { get; }
    public string Verses { get; } 

    public ScriptureReference(string book, int chapter, string verses)
    {
        Book = book;
        Chapter = chapter;
        Verses = verses;
    }

    public override string ToString() => $"{Book} {Chapter}:{Verses}";
}
