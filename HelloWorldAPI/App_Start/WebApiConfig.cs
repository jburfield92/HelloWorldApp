//////////////////////////////////////////////////////////////////////////////////////////////////////
//
//      FILE NAME: WebApiConfig.cs
//      DATE: 11/20/2016
//
//      DESCRIPTION: WebApi config class
//
//      CHANGES:
//
//      DATE        NAME            DECRIPTION
//      ----------  ----------      ----------
//      11/20/2016  Joseph B.       Initial
//////////////////////////////////////////////////////////////////////////////////////////////////////

using System.Web.Http;

namespace HelloWorldAPI
{
    /// <summary> WebApi config class
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary> Registers the API route
        /// </summary>
        /// <param name="config"></param>
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "HelloWorldAPI",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
