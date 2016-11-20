//////////////////////////////////////////////////////////////////////////////////////////////////////
//
//      FILE NAME: Global.asax
//      DATE: 11/20/2016
//
//      DESCRIPTION: Global page
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
    /// <summary> Global class
    /// </summary>
    public class WebApiApplication : System.Web.HttpApplication
    {
        /// <summary> Start point for the application
        /// </summary>
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}