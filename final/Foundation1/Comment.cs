public class Comment
{
    public string _personName;
    public string _commentText;

    public void DisplayComment()
    {
        Console.WriteLine($"\tUser-{ _personName}- Comment: {_commentText}");
    }
    
}