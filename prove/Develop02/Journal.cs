class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();
    public void DisplayAllEntries()
    {

    }
    public void WriteEntriesToFile(string fileName)
    {
        // using (StreamWriter outputFile = new StreamWriter(fileName))
        // {
        //     foreach(JournalEntry entry in entries)
        //     {
        //         outputFile.WriteLine(entry.ToString());
        //     }
        // }
    }
    public void AddEntry(JournalEntry entry)
    {
        entries.Add(entry);
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