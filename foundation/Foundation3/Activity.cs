using System;

public abstract class Activity
{
  private DateTime _date;
  private int _minutes;

  public DateTime GetDate()
  {
    return _date;
  } 

  public void SetDate(DateTime date)
  {
    _date = date;
  }

  public int GetDuration()
  {
    return _minutes;
  }

  public void SetDuration(int minutes)
  {
    _minutes = minutes;
  }

  public Activity(DateTime date, int minutes)
  {
    _date = date;
    _minutes = minutes;
  }

  public abstract double GetDistance();
  public abstract double GetSpeed();
  public abstract double GetPace();
  public virtual string GetSummary()
  {
    return $"{GetDate(): dd MMM yyyy} {GetType().Name} ({GetDuration()} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace {GetPace():0.0} min per km";
  }

    public static implicit operator Activity(List<Activity> v)
    {
        throw new NotImplementedException();
    }
}