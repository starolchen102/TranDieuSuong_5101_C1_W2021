﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace TranDieuSuong_5101_C1_W2021
{
  public static class WebApiConfig
  {
    public static void Register(HttpConfiguration config)
    {
      // Web API configuration and services

      // Web API routes
      config.MapHttpAttributeRoutes();

      config.Routes.MapHttpRoute(
          name: "DefaultApi",
          routeTemplate: "api/{controller}/{action}/{id}",
          defaults: new { id = RouteParameter.Optional }
      );
    }
  }
}
