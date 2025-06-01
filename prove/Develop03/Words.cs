using System;

public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word, bool hide)
    {
        _word = word;
        _isHidden = hide;
    }
    public bool GetHidden()
    {
        return _isHidden;
    }

    public void hide()
    {
        _isHidden = true;
    }
    public void SetWord(string word)
    {
        _word = word;
    }
    public string GetDisplayWord()
    {
        string _displayWord = _word;
        if (_isHidden == true)
        {
            _displayWord = new string('_', _word.Length);

            // List<string> _char = _word.Split().ToList();
            // List<string> _newChars = new List<string>();
            // //int _len =  _word.Length; 
            // foreach (string i in _char)
            // {
            //     string _newChar = "_";
            //     _newChars.Add(_newChar);
            // }
            // _word = string.Join("", _newChars);
        }
        else
        {

        }
        return _displayWord;
    }
    
    
}
