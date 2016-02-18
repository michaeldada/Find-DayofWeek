using Nancy;
using FindDayProject.Objects;
using System.Collections.Generic;

namespace FindDayProject
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/output"] = _ => {
        FindDay newFindDay = new FindDay(Request.Form["year"],Request.Form["month"],Request.Form["day"]);
        string output = newFindDay.DayOfWeek();
        return View["output.cshtml", output];
      };
    }
  }
}
