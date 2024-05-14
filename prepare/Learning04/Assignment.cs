public class Assignment
{
    private string _studentName;
    private String _topic;


    public Assignment(string name, string topic)
    {
        _studentName=name;
        _topic=topic;
    }

    public void SetStudentName(string name)
    {
        _studentName=name;
    }
    public void SetTopic(string topic)
    {
        _topic=topic;
    }
     public string GetStudentName()
    {
        return _studentName;
    }
     public string GetTopic()
    {
      return _topic;
    }
    public string GetSummary()
    {
        string sumary =$"{_studentName} - {_topic}";
        return sumary;
    }
}
