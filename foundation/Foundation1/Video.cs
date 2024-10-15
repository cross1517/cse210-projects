using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _listComments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _listComments = new List<Comment>();

        for (int i = 0; i < 3; i++)
        {
            AddComment();
        }
    }

    public int CommentsNumber()
    {
        return _listComments.Count;
    }

    public string GetVideoInfo()
    {
        return $"Title: {_title}, Author: {_author}, Length: {_length} seconds, Comments: {CommentsNumber()}";
    }

    private void AddComment()
    {
        Comment newComment = new Comment();
        _listComments.Add(newComment);
    }
    public List<Comment> GetComments()
    {
        return _listComments;
    }
}