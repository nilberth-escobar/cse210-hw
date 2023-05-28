using System;
using System.Collections.Generic;

// Represents a scripture passage.
class Scripture
{
    private string _reference; // The reference of the scripture.
    private List<Word> words; // A list of words in the scripture.

    // Constructor that initializes the scripture with the given reference and text.
    public Scripture(string reference, string text)
    {
        this._reference = reference;
        words = new List<Word>();

        // Split the text into individual words and create Word objects for each word.
        string[] textWords = text.Split(' ');
        foreach (string word in textWords)
        {
            words.Add(new Word(word));
        }
    }

    // Display the scripture reference and the words of the scripture.
    public void Display()
    {
        Console.WriteLine($"{_reference}:");
        foreach (Word word in words)
        {
            // If the word is hidden, display dashes. Otherwise, display the word.
            Console.Write(word._isHidden ? "---- " : word._text + " ");
        }
    }

    // Hide a random visible (not already hidden) word in the scripture.
    public void HideRandomWord()
    {
        // Get a list of visible words in the scripture.
        List<Word> visibleWords = GetVisibleWords();

        // If there are visible words, choose a random word from the list and hide it.
        if (visibleWords.Count > 0)
        {
            Random random = new Random();
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

    // Check if there are any hidden words in the scripture.
    public bool HasHiddenWords()
    {
        foreach (Word word in words)
        {
            // If a word is not hidden, return true (indicating that there are hidden words).
            if (!word._isHidden)
            {
                return true;
            }
        }

        // If all words are hidden, return false.
        return false;
    }

    // Get a list of visible (not already hidden) words in the scripture.
    private List<Word> GetVisibleWords()
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in words)
        {
            // If a word is not hidden, add it to the list of visible words.
            if (!word._isHidden)
            {
                visibleWords.Add(word);
            }
        }
        return visibleWords;
    }
}
