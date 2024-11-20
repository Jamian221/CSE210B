class Scripture{
    // attributes
    private Reference _reference;
    // reference variable 
    private List<Word> _words = new List<Word>();
    // creates a list of words as a class

    private int _hiddenWordAmount;

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
        _hiddenWordAmount = _words.Count;
    }

    public void DisplayScripture(){
        // clears previous iteration of the scripture
        Console.Clear();
        // prints the reference
        Console.Write($"{_reference.GetReference()} -");
        // prints each word individually
        foreach (Word word in _words){
            Console.Write($" {word.GetWord()}");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Press 'enter' to hide more words or 'quit' to exit");
    }
    public void HideWords(){
        for (int i = 0; i < 3; i++){
            // creates a random index for the word list
            int randomIndex = random.Next(0, _words.Count);
            // select a random item from the list and remove it
            Word randomWord = _words[randomIndex];
            bool cont = false;
            do {
                if (_hiddenWordAmount !=0){
                    if (randomWord.CheckIfHidden() == true){
                        randomIndex = random.Next(0, _words.Count);
                        randomWord = _words[randomIndex];
                    } else {
                        _hiddenWordAmount--;
                        cont = true;
                    }
                } else cont = true;
            } while(cont == false);
            randomWord.HideWord();
        }
    }
    public bool CheckIfDone(){
        if (_hiddenWordAmount == 0) return true;
        else return false;
    }
}