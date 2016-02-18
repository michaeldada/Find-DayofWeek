using System.Collections.Generic;
using Xunit;
namespace FindDayProject.Objects
{
  public class FindDayTest
  {
    [Fact]
    public void FindDay_02182016_Thursday()
    {
      FindDay newFindDay = new FindDay(2016, 2, 18);
      Assert.Equal("Day of Week :Thursday", newFindDay.DayOfWeek());
    }
    [Fact]
    public void FindDay_01011970_Thursday()
    {
      FindDay newFindDay = new FindDay(1970, 1, 1);
      Assert.Equal("Day of Week :Thursday", newFindDay.DayOfWeek());
    }
    [Fact]
    public void FindDay_02192016_Friday()
    {
      FindDay newFindDay = new FindDay(2016, 2, 19);
      Assert.Equal("Day of Week :Friday", newFindDay.DayOfWeek());
    }
    [Fact]
    public void FindDay_15151555_PleaseEnterAValidDate()
    {
      FindDay newFindDay = new FindDay(1555,15,15);
      Assert.Equal("Please Enter a Valid Date", newFindDay.DayOfWeek());
    }
  }
}
