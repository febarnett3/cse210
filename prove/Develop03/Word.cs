class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string text)
    {
        this._word = text;
        _isHidden = false;
    }

    public string Text
    {
        get { return _isHidden ? GetHiddenText() : _word; }
    }

    public bool IsHidden
    {
        get { return _isHidden; }
    }

    public void Hide()
    {
        _isHidden = true;
    }

    private string GetHiddenText()
    {
        return new string('_', _word.Length);
    }
}
