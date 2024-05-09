public class Reference
{
    private String _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //----------------------------------------

    public Reference(String book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(String book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    //-------------------------------------------------------------------

    public String GetDisplayText()
    {
        String refDisplay = $"{_book} {_chapter}:{_verse}-{_endVerse}";

        return refDisplay;
    }





}