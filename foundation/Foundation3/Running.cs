using System;

public class Running : Activity
{
  private double _distance;

  public void SetDistance(double value)
  {
    _distance = value;
  }

  public Running(DateTime date, int minutes, double distance) : base(date, minutes)
  {
    _distance = distance;
  }

  public override double GetDistance()
  {
    return _distance;
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