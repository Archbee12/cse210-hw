using System;

public class EternalGoal : Goal
{
  public EternalGoal(string name, string description, int points) : base(name, description, points)
  {

  }

  public override void RecordEvent()
  {
    _points += 0;
  }

  public override bool IsComplete()
  {
    return false;
  }

    public override string GetStringRepresentation()
    {
        return $"[ ] EternalGoal, {GetDetailsString()}";
    }
}