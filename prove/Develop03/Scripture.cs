public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    //--------------------------------------------------

    public Scripture(Reference reference, String text)
    {
        _reference = reference;
        String[] toSplit = text.Split(" ");
        List<string> crudeList = toSplit.ToList();
        foreach (String word in crudeList)
        {
            Word wordText = new Word(word);
            _words.Add(wordText);
        }

    }

    //-----------------------------------------------------

    public void HideRandomWords(int numberToHide)
    {

    }

    public String GetDisplayText()
    {
        String scriptDisplay = _reference.GetDisplayText() + " ";

        foreach (Word wordObj in _words)
        {
            scriptDisplay = scriptDisplay + wordObj.GetDisplayText() + " ";
        }
        
        return scriptDisplay;
    }

    public Boolean IsCompletelyHidden()
    {
        return false;
    }
}