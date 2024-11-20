class Reference{
    // attributes
    private string _reference;

    // methods

    // constructor that takes a reference string and sets it to an attribute
    public Reference(string reference){
        _reference = reference;
    }
    // returns reference string
    public string GetReference(){
        return _reference;
    }
}