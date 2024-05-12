public class Reference
{
    private String _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    public Reference()
    {

    }
    public Reference(string book, int chapter, int verse)
    {
        _book=book;
        _chapter= chapter;
        _verse=verse; 
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book=book;
        _chapter= chapter;
        _verse=verse;
        _endVerse=endVerse;
    }
    public string GetDisplayText()
    {
        string text;
        if (_verse != _endVerse)
        {
            text= $"{_book} {_chapter}:{_verse}-{_endVerse} ";  
        }else {
            text= $"{_book} {_chapter}:{_verse} ";  
        }
        return text;
    }
}