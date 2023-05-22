public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseFrom;
    private int _verseTo;
    private string _text;

    public Reference(string book, int chapter, string text, int verseFrom, int verseTo)
    {
        this._book = book;
        this._chapter = chapter;
        this._verseFrom = verseFrom;
        this._verseTo = verseTo;
        this._text = text;
    }

    public Reference(string book, int chapter, string text, int verseFrom)
    {
        this._book = book;
        this._chapter = chapter;
        this._verseFrom = verseFrom;
        this._verseTo = verseFrom;
        this._text = text;
    }


    public string GetText(){
        return this._text;
    }

    public string ConvertToString()
    {
        if (_verseFrom == _verseTo)
            {
                return $"{_book} {_chapter}:{_verseFrom}";
            } else {
                return $"{_book} {_chapter}:{_verseFrom}-{_verseTo}";
            }
    }
}
