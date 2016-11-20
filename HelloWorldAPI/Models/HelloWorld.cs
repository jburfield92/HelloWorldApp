//////////////////////////////////////////////////////////////////////////////////////////////////////
//
//      FILE NAME: HelloWorld.cs
//      DATE: 11/20/2016
//
//      DESCRIPTION: HelloWorld message Model
//
//      CHANGES:
//
//      DATE        NAME            DECRIPTION
//      ----------  ----------      ----------
//      11/20/2016  Joseph B.       Initial
//////////////////////////////////////////////////////////////////////////////////////////////////////

namespace HelloWorldAPI.Models
{
    /// <summary> HelloWorld message Model
    /// </summary>
    public class HelloWorld
    {
        /// <summary> The HelloWorld message
        /// </summary>
        public string Message
        {
            get
            {
                return "Hello World";
            }
        }
    }
}