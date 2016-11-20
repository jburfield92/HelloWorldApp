//////////////////////////////////////////////////////////////////////////////////////////////////////
//
//      FILE NAME: Program.cs
//      DATE: 11/20/2016
//
//      DESCRIPTION: Program to show Hello World
//
//      CHANGES:
//
//      DATE        NAME            DECRIPTION
//      ----------  ----------      ----------
//      11/20/2016  Joseph B.       Initial
//////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace HelloWorldConsole
{
    /// <summary> Program to show Hello World
    /// </summary>
    public class Program
    {
        /// <summary> HttpClient to make API call
        /// </summary>
        private static HttpClient client = new HttpClient();

        /// <summary> Main method for Console app
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            WriteMessageAsync().Wait();
            Console.WriteLine(Constants.EnterMessage);
            Console.ReadLine();
        }

        /// <summary> Writes a HelloWorld message asynchronously
        /// </summary>
        /// <returns></returns>
        private static async Task WriteMessageAsync()
        {
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings[Constants.HelloWorldAPIURLKey]);
            client.DefaultRequestHeaders.Accept.Clear();

            string message = string.Empty;
                
            HttpResponseMessage response = await client.GetAsync(Constants.HelloWorldAPIPath);

            if (response.IsSuccessStatusCode)
            {
                message = await response.Content.ReadAsStringAsync();
            }

            string writeMode = ConfigurationManager.AppSettings[Constants.WriteMode];

            if (writeMode == Enums.WriteModes.Console.ToString())
            {
                Console.WriteLine(message);
            }
            else if (writeMode == Enums.WriteModes.Database.ToString())
            {
                // db write call
            }
            else
            {
                // write/log error message?
            }
        }
    }
}