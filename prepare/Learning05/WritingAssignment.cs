using System;

public class WritingAssignment : Assignment
{
    string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_studentName} is working on writing a new book on {_topic}. Title: {_title}";
    }
}