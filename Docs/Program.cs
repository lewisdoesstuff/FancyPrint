using System;
namespace Docs
{
    class Docs
    {
        static void Main(string[] args)
        {
            // 1st parameter: Method to be printed inside []
            // 2nd parameter: Message to be displayed.
            FancyPrint.Print.WriteSuccess("Docs", "This worked!");
            FancyPrint.Print.WriteWarn("Docs", "This kinda worked!");
            FancyPrint.Print.WriteError("Docs", "This didn't work!");
            FancyPrint.Print.WriteStandard("Docs", "This is some information.");
           
            // Change method, success, warning, and error colors to anything you wish! 
            FancyPrint.Colors.Method = ConsoleColor.Magenta;
            Console.WriteLine();
            FancyPrint.Print.WriteSuccess("Docs", "Now in purple!");
            
            FancyPrint.Colors.Success = ConsoleColor.Cyan;
            Console.WriteLine();
            FancyPrint.Print.WriteSuccess("Docs", "No Added Sugar!");
            Console.WriteLine();
            
            // Print only text by passing an empty string as the method
            FancyPrint.Print.WriteWarn("","Just the text!");
            Console.ReadLine();
        }
    }
}