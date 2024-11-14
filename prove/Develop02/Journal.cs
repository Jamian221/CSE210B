using System.IO.Enumeration;

class Journal
{
    private List<JournalEntry> _entries = new List<JournalEntry>();
    private string _fileName;
    public void DisplayAllEntries()
    {
        foreach (JournalEntry entry in _entries){
            entry.EntryToString();
        }
    }
    private void GetFileName(string prompt){
        Console.Write(prompt);
        _fileName = Console.ReadLine();
    }
    public void WriteEntriesToFile(string fileName)
    {
        GetFileName("What file would you like to save to? ");
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(JournalEntry entry in _entries)
            {
                outputFile.WriteLine(entry.ToString());
            }
        }
    }
    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }
    public void ReadEntriesFromFile()
    {
        // string[] lines = System.IO.File.ReadAllLines(fileName);

        // foreach(string line in lines){
        //     string[] parts = line.Split("#");

        //     string date = parts[0];
        //     string question = parts[1];
        //     string entryText = parts[2];

        //     JournalEntry entry = new JournalEntry(date, question, entryText);
        //     this.AddEntry(entry);
        // }
    }
}