using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace WebApi
{
    public static class WebApiConfig
    {
        public static object DateFormatting { get; private set; }

        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var jsonformatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonformatter.SerializerSettings.DateFormatHandling = DateFormatHandling.MicrosoftDateFormat;

            foreach (var formatter in config.Formatters)
            {
                Debug.WriteLine(formatter.GetType());
            }
        }
    }
}
