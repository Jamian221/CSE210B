using System.IO;
using System.Runtime.InteropServices;

class Journal
{
    private List<JournalEntry> _entries = new List<JournalEntry>();
    public void DisplayAllEntries()
    {
        foreach (JournalEntry entry in _entries){
            Console.WriteLine(entry.EntryDisplay());
        }
    }
    private string GetFileName(string prompt){
        Console.Write(prompt);
        string fileName = Console.ReadLine();
        return fileName;
    }
    public void WriteEntriesToFile()
    {
        string fileName = GetFileName("What file would you like to save to? ");
        using (StreamWriter outputFile = new StreamWriter(fileName))

        {
            foreach(JournalEntry entry in _entries)
            {
                string output = entry.EntryToString();
                Console.WriteLine(output);
                outputFile.WriteLine(output);
                
            }
            _entries.Clear();
        }
    }
    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }
    public void ReadEntriesFromFile()
    {
        string fileName = GetFileName("What file would you like to read from? ");
        string[] lines = File.ReadAllLines(fileName);


        foreach(string line in lines){
            string[] parts = line.Split("#");

            string date = parts[0];
            string question = parts[1];
            string entryText = parts[2];

            JournalEntry entry = new JournalEntry(date, question, entryText);
            AddEntry(entry);
        }
    }
}