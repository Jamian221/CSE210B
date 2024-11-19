class Word{
    private string _word;
    private bool _isHidden;
    private string _underscoreWord;
    public Word(string word){
        _word = word;
        _isHidden = false;
        _underscoreWord = "";
        for (int i = 0; i < _word.Length; i++){
            _underscoreWord = $"{_underscoreWord}_";
        }
    }
    public string GetWord(){
        if (_isHidden){
            return _underscoreWord;
        }
        else {
            return _word;
        }
    }
    public void HideWord(){
        _isHidden = true;
    }
    public bool CheckIfHidden(){
        return _isHidden;
    }
}