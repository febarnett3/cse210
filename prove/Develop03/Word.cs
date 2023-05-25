class Word
{
    // Attributes
    private string _word;
    private bool _isHidden;

    // Constructor
    public Word(string text)
    {
        this._word = text;
        _isHidden = false;
    }

    // A couple 'getters'
    //Gets the "current" text of the word.
    public string Text
    {
        // This text returns either the hidden version of visible version of the word depending on whether _isHidden is true or false.
        // The hidden text will access the private function GetHiddenText() in this class to return a string of underscores.
        get {return _isHidden ? GetHiddenText() : _word;}
    }

    // Gets the boolean value of the 'IsHidden'
    public bool IsHidden
    {
        get {return _isHidden;}
    }

    //Behaviors
    public void Hide()
    {
        _isHidden = true;
    }

    private string GetHiddenText()
    {
        // Returns a new string of the word's length in underscores.
        return new string('_', _word.Length);
    }
}
