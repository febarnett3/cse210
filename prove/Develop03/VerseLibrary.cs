using System;
using System.Collections.Generic;
class VerseLibrary
{
    // Attributes
    private List<Reference> _verses;
    private Random _random;

    // Constructor
    // What's being initalized in this library.
    public VerseLibrary()
    {
        _verses = new List<Reference>();
        _random = new Random();

        // Add verses to the library
        _verses.Add(new Reference("Genesis", 1, "In the beginning God created the heaven and the earth.", 3));

        // Add more verses as desired
        _verses.Add(new Reference("John", 3, "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life.", 16));
        
        _verses.Add(new Reference ("Moses", 1, "For behold this is my work and my glory to bring to pass the immortality and eternal life of man.", 39));
        
        _verses.Add(new Reference ("Moses", 7, "And the Lord called his people Zion because they were of one heart and one mind and dwelt in righteousness and there was no poor among them.", 18));
        
        _verses.Add(new Reference ("Genesis", 2, "Therefore shall a man leave his father and his mother and shall cleave unto his wife and they shall be one flesh.", 24));
        
        _verses.Add(new Reference ("Isaiah", 1, "Come now and let us reason together saith the Lord though your sins be as scarlet they shall be as white as snow; though they be red like crimson they shall be as wool.", 18));
        
        _verses.Add(new Reference("Isaiah", 5, "Woe unto them that call evil good and good evil that put darkness for light and light for darkness that put bitter for sweet and sweet for bitter!", 20));

        _verses.Add(new Reference("Matthew", 5, "Ye are the light of the world. A city that is set on an hill cannot be hid. Neither do men light a candle and put it under a bushel but on a candlestick and it giveth light unto all that are in the house. Let your light so shine before men that they may see your good works and glorify your Father which is in heaven.", 14, 16));

        _verses.Add(new Reference("Alma", 41, "Do not suppose because it has been spoken concerning restoration that ye shall be restored from sin to happiness. Behold I say unto you wickedness never was happiness.", 10));

        _verses.Add(new Reference("Moroni", 10, "And when ye shall receive these things I would exhort you that ye would ask God the Eternal Father in the name of Christ if these things are not true and if ye shall ask with a sincere heart with real intent having faith in Christ he will manifest the truth of it unto you by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.", 4, 5));

        _verses.Add(new Reference("D&C", 6, "Look unto me in every thought doubt not fear not.", 36));

        _verses.Add(new Reference("D&C", 18, "Remember the worth of souls is great in the sight of God. For behold the Lord your Redeemer suffered death in the flesh wherefore he suffered the pain of all men that all men might repent and come unto him.", 10, 11));

    }

    // Behavior
    public Reference GetRandomVerse()
    {
        // Defining a random index to select a verse.
        int index = _random.Next(_verses.Count);
        // Returns the verse of the specified random index.
        return _verses[index];
    }
}