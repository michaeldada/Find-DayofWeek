using System.Collections.Generic;
using System;

namespace FindDayProject.Objects
{
  public class FindDay
  {
    private int _year;
    private int _month;
    private int _day;

    public FindDay(int year, int month, int day)
    {
      _year = year;
      _month = month;
      _day = day;
    }

    public string DayOfWeek()
    {
      try
      {
        DateTime newDateTime = new DateTime(_year, _month, _day);
        return "Day of Week :" + newDateTime.DayOfWeek.ToString();
      }
      catch(System.ArgumentOutOfRangeException e)
      {
        return "Please Enter a Valid Date";
      }

    }
  }
}
