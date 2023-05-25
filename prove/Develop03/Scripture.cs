public class Scripture
{
    // Attributes
    private string _text;
    private List<Word> _words;

    // Constructor
    public Scripture(string text)
    {
        // Initialize the scripture text
        _text = text;

        // Split the scripture text into individual words
        string[] wordArray = _text.Split(' ');

        // Create Word objects for each word in the scripture
        // Each item in the words list needs to be a Word object so it can have the behaviors defined in Word.cs
        _words = new List<Word>();
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    // Behaviors
    public string GetVisibleText()
    {
        // Initialize the visible text.
        // visibleText is what the user is currently seeing as the program is running.
        string visibleText = "";

        // Iterates through each word in the List _words adding the text of the word to the list along with a space.
        foreach (Word word in _words)
        {
            // This word.Text can be found in the Word.cs class. Depending on whether the bool value is 'IsHidden' is true or false, it will return the visible or hidden version of the word.
            visibleText += word.Text;
            visibleText += " ";
        }

        // Returns the visible text of the scripture and trims the extra space at then end of the sentence verse.
        return visibleText.TrimEnd();
    }

    public void HideWords()
    {

        // Find all visible words.
        // The '.IsHidden' returns a boolean value from Word.cs
        List<Word> visibleWords = _words.FindAll(word => !word.IsHidden);

        // If the words are not completely hidden.
        // Words would be 'completely hidden' is there are 0 visible words.
        if (visibleWords.Count > 0)
        {
            // Generating 3 random indexes of the visible words to hide.
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

    public bool IsCompletelyHidden()
    {
        // True for all function checks to see is every word is hidden in the _words list.
        // Remember, '.IsHidden' is a boolean value, so each item would need to return true for it to be completely hidden.
        return _words.TrueForAll(word => word.IsHidden);
    }
}
