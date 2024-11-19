class Word{
    // attributes
    // string for if the word isn't hidden
    private string _word;
    // string for if word is hidden
    private string _underscoreWord;
    // if the word is hidden
    private bool _isHidden;
    // constructor - takes a word as a string, says  word isn't hidden, creates hidden word string (same amount of underscores as letters)
    public Word(string word){
        _word = word;
        _isHidden = false;
        _underscoreWord = "";
        // for each letter in the word, add an underscore to the hidden word
        for (int i = 0; i < _word.Length; i++){
            _underscoreWord = $"{_underscoreWord}_";
        }
    }
    // returns the hidden word if hidden and word if it's not
    public string GetWord(){
        if (_isHidden){
            return _underscoreWord;
        }
        else {
            return _word;
        }
    }
    // hides the word
    public void HideWord(){
        _isHidden = true;
    }
    // returns the bool for if it is hidden
    public bool CheckIfHidden(){
        return _isHidden;
    }
}