using System;

public class ChecklistGoal : Goal
{
  public int _amountCompleted;
  private int _target;
  public readonly int _bonus;

  public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
  {
    _amountCompleted = 0;
    _target = target;
    _bonus = bonus;
  }

  public override void RecordEvent()
  {
    _amountCompleted++;
    if (_amountCompleted >= _target)
    {
      _points += _bonus;
    }
  }
  public override bool IsComplete()
  {
    return _amountCompleted >= _target;
  }

  public override string GetDetailsString()
  {
    return (_amountCompleted >= _target ? "[X] " : "[ ] ") + $"{GetName()} - {GetDescription()} (Completed {_amountCompleted}/{_target} times)";
  }

  public override string GetStringRepresentation()
  {
      return $"ChecklistGoal, {GetName()}, {GetDescription()}, {GetPoints()}, {_amountCompleted}, {_target}, {_bonus}";
  }
}