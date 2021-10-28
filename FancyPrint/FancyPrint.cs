using System;

namespace FancyPrint
{
    public static class Colors
    {
        public static ConsoleColor Success = ConsoleColor.Green;
        public static ConsoleColor Warn = ConsoleColor.Yellow;
        public static ConsoleColor Error = ConsoleColor.Red;

        public static ConsoleColor Method = ConsoleColor.Cyan;
    }

    public static class Print
    {
        public static void WriteStandard(string method, string text)
        {
            Console.ForegroundColor = Colors.Method;
            Console.Write($"[{method}] ");
            Console.ResetColor();
            Console.Write(text);
            Console.WriteLine();


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