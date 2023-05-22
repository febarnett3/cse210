public class Scripture
{
    private string _text;
    private List<Word> _words;

    public Scripture(string text)
    {
        // Initialize the scripture text
        _text = text;

        // Split the scripture text into individual words
        string[] wordArray = _text.Split(' ');

        // Create Word objects for each word in the scripture
        _words = new List<Word>();
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public string GetVisibleText()
    {
        string visibleText = "";

        foreach (Word word in _words)
        {
            visibleText += word.Text;
            visibleText += " ";
        }

        return visibleText.TrimEnd();
    }
    


    public void HideWord()
    {

        // Find all visible words
        List<Word> visibleWords = _words.FindAll(word => !word.IsHidden);


        // If the words are not completely hidden.
        if (visibleWords.Count > 0)
        {
            // First word to randomly select and hide.
            Random random1 = new Random();
            int index1 = random1.Next(visibleWords.Count);
            visibleWords[index1].Hide();

            // Second word to randomly select a word to hide.
            Random random2 = new Random();
            int index2 = random2.Next(visibleWords.Count);
            visibleWords[index2].Hide();

            // Third word to randomly select a word to hide.
            Random random3 = new Random();
            int index3 = random3.Next(visibleWords.Count);
            visibleWords[index3].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return _words.TrueForAll(word => word.IsHidden);
    }
}
