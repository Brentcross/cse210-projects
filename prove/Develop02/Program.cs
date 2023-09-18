using System;
using System.Collections.Generic;
using System.IO; //the only way I could get this to run was by adding this line here. Not sure why it wasnt before, but it seems to work with this one. 
using System.Linq;

class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; } 

    public override string ToString()
    {
        return $"{Date} | {Prompt} | {Response}";
    }
}

class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        _entries.Add(new Entry { Prompt = prompt, Response = response, Date = DateTime.Now.ToString() });
    }

    public void DisplayJournal()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

public void SaveToFile(string _filename)
{
    List<string> _toSave = new List<string>();
    foreach (var entry in _entries)
    {
        _toSave.Add(entry.ToString());
    }
    File.WriteAllLines(_filename, _toSave);
}

public void LoadFromFile(string filename)
{
    _entries.Clear();
    
    string[] lines = File.ReadAllLines(filename);
    foreach (string line in lines)
    {
        var parts = line.Split('|').Select(p => p.Trim()).ToArray();
        
        _entries.Add(new Entry { Date = parts[0], Prompt = parts[1], Response = parts[2] });
    }
}

}

class Program
{
    static void Main()
    {
        Journal _journal = new Journal();
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "Were there sad parts in your day, and how could you fix them?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What changes did you make today that made you a better person?",
            "Did you say 'I love you' today? To who? And why?",

        };

        bool running = true;
        while (running)
        {
            Console.WriteLine("Please choose one of the following options below: ");
            Console.WriteLine("1. Write your new entry");
            Console.WriteLine("2. Display your previous journals");
            Console.WriteLine("3. Save your journal to a file");
            Console.WriteLine("4. Load old journals from a file");
            Console.WriteLine("5. Exit writtings");

            Console.Write("What is your selection?: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    var prompt = prompts[new Random().Next(prompts.Count)];
                    Console.WriteLine(prompt);
                    var response = Console.ReadLine();
                    _journal.AddEntry(prompt, response);
                    break;
                case 2:
                    _journal.DisplayJournal();
                    break;
                case 3:
                    Console.Write("Enter filename: ");
                    var saveFilename = Console.ReadLine();
                    _journal.SaveToFile(saveFilename);
                    break;
                case 4:
                    Console.Write("Enter filename: ");
                    var loadFilename = Console.ReadLine();
                    _journal.LoadFromFile(loadFilename);
                    break;
                case 5:
                    running = false;
                    break;
            }
        }
    }
}
