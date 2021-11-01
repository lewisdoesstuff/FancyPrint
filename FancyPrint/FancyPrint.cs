// Lew's FancyPrint Library!
using System;

namespace FancyPrint
{
    /// <summary>
    /// Colors defined here!
    /// Method text is printed [In brackets] at the start of the line.
    /// Override in your program with FancyPrint.Colors.x = ConsoleColor.x;
    /// </summary>
    public static class Colors
    {
        public static ConsoleColor Standard = ConsoleColor.White;
        public static ConsoleColor Success = ConsoleColor.Green;
        public static ConsoleColor Warn = ConsoleColor.Yellow;
        public static ConsoleColor Error = ConsoleColor.Red;
        
        public static ConsoleColor Method = ConsoleColor.Cyan;
    }

    public static class Print
    {
        /// <summary>
        /// Method is identical for all options.
        /// Set color to Method color, print inside [brackets]
        /// Rest color, write the text (in specific color if not WriteStandard), then print newline.
        /// </summary>
        /// <param name="method"> Given method (or anything, really) to be printed inside [brackets] </param>
        /// <param name="text"> The text you'd like printing. Add \n to print newlines as usual. </param>
        public static void WriteStandard(string method, string text)
        {
            Console.ForegroundColor = Colors.Method;
            Console.Write($"[{method}] ");
            Console.ForegroundColor = Colors.Standard;
            Console.Write(text);
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void WriteSuccess(string method, string text)
        {
            Console.ForegroundColor = Colors.Method;
            Console.Write($"[{method}] ");
            Console.ForegroundColor = Colors.Success;
            Console.Write(text);
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void WriteWarn(string method, string text)
        {
            Console.ForegroundColor = Colors.Method;
            Console.Write($"[{method}] ");
            Console.ForegroundColor = Colors.Warn;
            Console.Write(text);
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void WriteError(string method, string text)
        {
            Console.ForegroundColor = Colors.Method;
            Console.Write($"[{method}] ");
            Console.ForegroundColor = Colors.Error;
            Console.Write(text);
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}