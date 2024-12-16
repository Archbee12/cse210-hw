using System;

public abstract class Goal
{
  private string _shortName;
  private string _description;
  protected int _points;

  protected Goal(string name, string description, int points)
  {
    _shortName = name;
    _description = description;
    _points = points;
  }

  public string GetName()
  {
    return _shortName;
  }

  public string GetDescription()
  {
    return _description;
  }

  public int GetPoints()
  {
    return _points;
  }

  public abstract void RecordEvent();
  public abstract bool IsComplete();
  public virtual string GetDetailsString()
  {
    return (IsComplete() ? "[X]" : "[ ]") + $" {_shortName}: {_description} {_points} Points";
  }
  public abstract string GetStringRepresentation();

}