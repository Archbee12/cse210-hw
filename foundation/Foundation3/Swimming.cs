using System;

public class Swimming : Activity
{
  private int _laps;

  public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
  {
    _laps = laps;
  }

  public int GetLaps()
  {
    return _laps;
  }

  public override double GetDistance()
  {
    return GetLaps() * 50 / 1000;
  }

  public override double GetSpeed()
  {
    return GetDistance() / GetDuration() * 60;
  }

  public override double GetPace()
  {
    return GetDuration() / GetDistance();
  }
}