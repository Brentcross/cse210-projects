public class WritingAssignment : Assignment
{
    private string _writingTopic;

    public WritingAssignment(string studentName, string topic, string writingTopic)
        : base(studentName, topic)
    {
        _writingTopic = writingTopic;
    }

    public string GetWritingInformation()
    {
        return $"{_writingTopic} by {GetStudentName()}";
    }
}
