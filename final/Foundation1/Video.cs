public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public int GetCommentsNumber()
    {
        return _comments.Count;
    }
     public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title} - Author:{_author} - Length:{_length} Seconds");
        Console.WriteLine($"--{GetCommentsNumber()} Comments--");
        DisplayComments();
    }    
    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
           comment.DisplayComment();
        }
        Console.WriteLine("");
    }
    

}