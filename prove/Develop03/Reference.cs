using System;

public class Reference
{
  public string _book;
  public int _chapter;
  public int _verse;
  public int _endVerse;

  public Reference(string book, int chapter, int verse)
  {
    _book = book;
    _chapter = chapter;
    _verse = verse;
  }

  public Reference(string book, int chapter, int startVerse, int endVerse)
  {
    _book = book;
    _chapter = chapter;
    _endVerse = endVerse;
    _verse = startVerse;
  }

  public string GetDisplayText()
  {
    return _endVerse > _verse ? $"{_book} {_chapter} : {_verse}-{_endVerse}" : $"{_book} {_chapter}:{_verse}";
  }
}