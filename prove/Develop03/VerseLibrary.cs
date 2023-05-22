using System;
using System.Collections.Generic;
class VerseLibrary
{
    private List<Reference> _verses;
    private Random _random;

    public VerseLibrary()
    {
        _verses = new List<Reference>();
        _random = new Random();

        // Add verses to the library
        _verses.Add(new Reference("Genesis", 1, "In the beginning God created the heavens and the earth.", 1, 3));
        _verses.Add(new Reference("John", 3, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.", 16, 16));
        // Add more verses as desired
    }

    public Reference GetRandomVerse()
    {
        int index = _random.Next(_verses.Count);
        return _verses[index];
    }
}