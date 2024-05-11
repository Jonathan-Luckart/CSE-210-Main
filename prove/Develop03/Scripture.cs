using System;

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
        for (int i = 0; i < numberToHide; i++)
        {
        Random random = new Random();
        int j = random.Next(0, _words.Count);
        _words[j].Hide();
        }

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
        Boolean hiddenFully = false;
        int doesEqual = 0;

        foreach (Word wordObj in _words)
        {
            if (wordObj.GetDisplayText().Contains("_"))
            {
                doesEqual += 1;
            }
            
            if (doesEqual == _words.Count)
            {
                hiddenFully = true;
            }
        }

        return hiddenFully;
    }
}