class Scripture{
    private Reference _reference;
    // reference variable 
    private List<Word> _words = new List<Word>();
    // creates a list of words as a class
    public Scripture(string reference, string scriptureString){
        // creates the reference
        _reference = new Reference(reference);

        // splits the scripture into individual words
        string[] _scriptureWords = scriptureString.Split(" ");

        // add each word in the scripture to the word list
        foreach (string word in _scriptureWords){
            _words.Add(new Word(word));
        }
    }

    public void DisplayScripture(){
        // clears previous iteration of the scripture
        Console.Clear();
        // prints the reference
        Console.Write($"{_reference.DisplayReference()} -");
        // prints each word individually
        foreach (Word word in _words){
            Console.Write($" {word.GetWord()}");
        }
        Console.WriteLine(".");
    }
}