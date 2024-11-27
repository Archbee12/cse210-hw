using System;

public class Scripture
{
  private Reference _reference;
  private List<Word> _words;

  public Scripture(Reference reference, string text)
  {
    _reference = reference;
    _words = text.Split(' ').Select(w => new Word(w)).ToList();
  }

  public void HideRandomWords(int numberToHide)
  {
    Random random = new Random();
    var wordsToHide = _words.Where(w => !w.IsHidden()).OrderBy(x => random.Next()).Take(numberToHide);

    foreach (var word in wordsToHide)
    {
      word.Hide();
    }
  }

  public bool IsCompletelyHidden()
  {
    return _words.All(w => w.IsHidden());
  }

  public string GetDisplayText()
  {
    string displayText = string.Join(" ", _words.Select(w => w.GetDisplayText())); 
  
    return $"{_reference.GetDisplayText()}: {displayText}";
  }
  
}