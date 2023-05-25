public class Reference
{
    // Attributes
    private string _book;
    private int _chapter;
    private int _verseFrom;
    private int _verseTo;
    private string _text;

    // Constructors
    // If there is more than one verse.
    public Reference(string book, int chapter, string text, int verseFrom, int verseTo)
    {
        this._book = book;
        this._chapter = chapter;
        this._verseFrom = verseFrom;
        this._verseTo = verseTo;
        this._text = text;
    }

    // If there is one verse in the reference.
    public Reference(string book, int chapter, string text, int verseFrom)
    {
        this._book = book;
        this._chapter = chapter;
        this._verseFrom = verseFrom;
        this._verseTo = verseFrom;
        this._text = text;
    }

    // Getter
    // Gets the text of the reference. This text will be passed into an instance of scripture class in the program class.
    public string GetText(){
        return this._text;
    }

    //Returns the string format of the reference. Text is not included in this, it's JUST the reference.
    public string ConvertToString()
    {
        if (_verseFrom == _verseTo)
            {
                // If there is one verse.
                return $"{_book} {_chapter}:{_verseFrom}";
            } else {
                // If there is multiple verses.
                return $"{_book} {_chapter}:{_verseFrom}-{_verseTo}";
            }
    }
}
