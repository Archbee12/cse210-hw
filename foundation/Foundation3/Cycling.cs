using System;

public class Cycling : Activity
{
  public double _speed;

  public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
  {
    _speed = speed;
  }

  public override double GetSpeed()
  {
    return _speed;
  }

    public override double GetDistance()
    {
      return GetSpeed() * GetDuration() / 60;
    }

    public override double GetPace()
    {
      return 60 / GetSpeed();
    }
}