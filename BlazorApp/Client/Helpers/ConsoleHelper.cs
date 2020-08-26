using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Client.Helpers
{
    public class ConsoleHelper
    {
        public static void WriteToConsole(string text = "Hi form Blazor App")
        {
            Console.WriteLine(text);
        }
    }
}
