//https://stackoverflow.com/questions/16725848/how-to-split-text-into-words


using System.Diagnostics;
using System.Xml;

public class Scripture
{
    private Reference _reference = new Reference();

    private List<Word> _word = new List<Word>();
   
    public Scripture(Reference reference, string text)
    {
        _reference=reference;
       
        string[] splitted= text.Split(" ");
        foreach (var item in splitted)
        {
            Word word = new Word(item);
            _word.Add(word);
        }
    }
    public void HideRandomWords(int numberToHide)
    {   
        Random r = new Random();
        for (int i = 0; i < numberToHide; i++) 
        {
            if (IsCompletelyHidden()==false)
            {
                int randomIndex  = r.Next(0, _word.Count());
                while (_word[randomIndex].IsHidden()==true)
                {
                    randomIndex  = r.Next(0, _word.Count());

                }
                _word[randomIndex].Hide();
            }
        }
    }
    public string GetDisplayText()
    {
        string display;
        display=_reference.GetDisplayText();
        foreach (var item in _word)
        {
           
           if (item.IsHidden()==true)
            {
                display = display + " ----";
            }else
            {
                display = display + " " + item.GetDisplayText();
            }    
        }
        return display += ".";
    }
    public bool IsCompletelyHidden()
    {
        bool hidden = true;
        foreach (var item in _word)
        {
            if (item.IsHidden()==false)
            {
                hidden=false;
            }
        }
        return hidden;
    }
}