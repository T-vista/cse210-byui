using System;

public class Scripture
{
    private string _scriptureText; 
    private List<Word> _wordsOfText = new List<Word>();
    private Reference _reference;

    public Scripture()
    {
        _scriptureText = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        _reference = new Reference("1 Nephi", 3, 7);
        List<string> _split = _scriptureText.Split(' ').ToList();
        foreach (string i in _split)
        {
            Word w1 = new Word(i, false);
            _wordsOfText.Add(w1);
        }
    }
    public Scripture(string scriptureText, Reference reference)
    {
        _scriptureText = scriptureText;
        _reference = reference; 
        List<string> _split = _scriptureText.Split(' ').ToList();
        foreach (string i in _split)
        {
            Word w1 = new Word(i, false);
            _wordsOfText.Add(w1);
        }
    }

    static Random rnd = new Random();
    public void HideRandomWords()
    {
        for (int i = 0; i < 3; i++)
        {
            int _r = rnd.Next(_wordsOfText.Count);

            if (_wordsOfText[_r].GetHidden() == false)
            {
                _wordsOfText[_r].hide();
            }
            else if (_wordsOfText[_r].GetHidden() == true)
            {
                i--;
            }
        }

    }
    public string GetDisplayText()
    {
        List<string> _displayText = new List<string>();
        foreach (Word i in _wordsOfText)
        {
            _displayText.Add(i.GetDisplayWord());
        }
        string scripture = String.Join(" ", _displayText);
        return $"{_reference.GetDisplayText()} {scripture}";
    }
    public bool IsCompletelyHidden()
    {
        bool _yes = true;
        foreach (Word i in _wordsOfText)
        {
            if (i.GetHidden() == false)
            {
                _yes = false;
            }
        }
        return _yes;
    }
 
}