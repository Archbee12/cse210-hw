using System;

public class Fraction
{
  private int _top;
  private int _bottom;

  public Fraction()
  {
    _top = 1;
    _bottom = 1;
  }

  public Fraction(int wholeNumber)
  {
    _top = wholeNumber;
    _bottom = 1;
  }

  public Fraction(int top, int bottom)
  {
    _top = top;
    _bottom = bottom;
  }

  public int GetTop()
  {
    return _top;
  }

  public int SetTop(int top)
  {
    return _top = top;
  }

  public int GetBottom()
  {
    return _bottom;
  }

  public int SetBottom(int bottom)
  {
    return _bottom = bottom;
  }

  public string GetFractionString()
  {
    string fract = $"{_top}/{_bottom}";
    return fract;
  }

  public double GetDecimalValue()
  {
    double top = _top;
    double bottom = _bottom;

    double decimals = top/bottom;
    return decimals;
  }
}