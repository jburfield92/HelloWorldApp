//////////////////////////////////////////////////////////////////////////////////////////////////////
//
//      FILE NAME: HelloWorldController.cs
//      DATE: 11/20/2016
//
//      DESCRIPTION: HelloWorld message Controller
//
//      CHANGES:
//
//      DATE        NAME            DECRIPTION
//      ----------  ----------      ----------
//      11/20/2016  Joseph B.       Initial
//////////////////////////////////////////////////////////////////////////////////////////////////////

using HelloWorldAPI.Models;
using System.Web.Http;

namespace HelloWorldAPI.Controllers
{
    /// <summary> HelloWorld message Controller
    /// </summary>
    public class HelloWorldController : ApiController
    {
        /// <summary> The HelloWorld message model
        /// </summary>
        private HelloWorld HelloWorldMessage = new HelloWorld();

        /// <summary> Gets the HelloWorld message
        /// </summary>
        /// <returns></returns>
        public string GetMessage()
        {
            return HelloWorldMessage.Message;
        }
    }
}
