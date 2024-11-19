class Scripture{
    // attributes
    private Reference _reference;
    // reference variable 
    private List<Word> _words = new List<Word>();
    // creates a list of words as a class

    private Random random = new Random();

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
        Console.WriteLine();
    }
    public void HideWords(){
        for (int i = 0; i < 3; i++){
            // creates a random index for the word list
            int randomIndex = random.Next(0, _words.Count);
            // select a random item from the list and remove it
            Word randomWord = _words[randomIndex];
            randomWord.HideWord();
        }
    }
}