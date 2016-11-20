//////////////////////////////////////////////////////////////////////////////////////////////////////
//
//      FILE NAME: Enums.cs
//      DATE: 11/20/2016
//
//      DESCRIPTION: Console enums
//
//      CHANGES:
//
//      DATE        NAME            DECRIPTION
//      ----------  ----------      ----------
//      11/20/2016  Joseph B.       Initial
//////////////////////////////////////////////////////////////////////////////////////////////////////

namespace HelloWorldConsole
{
    /// <summary> Console enums
    /// </summary>
    public static class Enums
    {
        /// <summary> The possible write modes
        /// </summary>
        /// <remarks>
        /// Add write modes here, name should match string value used in App.Config key 'WriteMode'
        /// </remarks>
        public enum WriteModes
        {
            Console = 1,
            Database = 2
        }
    }
}