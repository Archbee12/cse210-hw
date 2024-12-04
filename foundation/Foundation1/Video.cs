using System;

public class Video 
{
  public string _title;
  public string _author;
  public int _length; //in seconds
  public List<Comment> _comments;

  public Video (string title, string author, int length)
  {
    _title = title;
    _author = author;
    _length = length;
    _comments = new List<Comment>();
  }

  public List<Comment> GetComment()
  {
    return _comments;
  } 

  public void AddComment(Comment comment)
  {
    _comments.Add(comment);
  }

  public int GetCommentNumber()
  {
    return _comments.Count;
  }

}