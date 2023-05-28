using System;
using System.Collections.Generic;

// Represents a word in the scripture.
class Word
{
    public string _text { get; } // The text of the word.
    public bool _isHidden { get; private set; } // Indicates whether the word is hidden or not.

    // Constructor that initializes the word with the given text and sets it as not hidden.
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hide the word by setting it as hidden.
    public void Hide()
    {
        _isHidden = true;
    }
}