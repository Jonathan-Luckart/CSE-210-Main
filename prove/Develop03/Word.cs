public class Word
{
    private String _text;
    //private Boolean _isHidden;

    //-------------------------------------

    public Word(String text)
    {
        _text = text;
       // _isHidden = false;
    }

    //-------------------------------------

    public void Hide()
    {
        char[] letters = _text.ToCharArray();
        String hiddenWord = "";

        foreach (Char single in letters)
        {
            String newChar = $"{single}";
            newChar = "_";
            hiddenWord = hiddenWord + newChar;
        }
        _text = hiddenWord;
    }

    /*public void Show()
    {
        Console.WriteLine($"{_text}");
    }

    public Boolean IsHidden()
    {
        return _isHidden;
    }*/

    public String GetDisplayText()
    {
        return _text;
    }
}