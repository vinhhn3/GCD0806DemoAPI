﻿using System.Web;
using System.Web.Mvc;

namespace GCD0806DemoAPI
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
