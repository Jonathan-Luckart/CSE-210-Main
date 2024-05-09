public class Word
{
    private String _text;
    private Boolean _isHidden;

    //-------------------------------------

    public Word(String text)
    {
        _text = text;
        _isHidden = false;
    }

    //-------------------------------------

    public void Hide()
    {

    }

    public void Show()
    {

    }

    public Boolean IsHidden()
    {
        return false;
    }

    public String GetDisplayText()
    {
        return _text;
    }
}