# FancyPrint
![Build](https://github.com/lewisdoesstuff/FancyPrint/actions/workflows/dotnet.yml/badge.svg)


A C# .NET Library for printing to the console with style!

## Description

FancyPrint is a simple .NET library used to print information to the console with preset formatting and color templates.
This should be a fairly drop-in replacement for `Console.WriteLine` statements, you'll just need to add a 'Method' to them.

The library contains 4 methods:
  - `WriteStandard` writes the text in white (or the default console foreground color)
  - `WriteError` writes the text in red 
  - `WriteWarn` writes the text in yellow
  - `WriteSuccess` writes the text in green.

All colors are configurable though `FancyPrint.Colors`

## Getting Started

### Dependencies

* Project targets .NET 5.0.
* The .NET Runtime is required for running console applications.

### Building

* Building the library from scratch just requires you to download the solution, then build this through your .NET IDE of choice
* You can also use `dotnet build` from the CLI to build the file.

### Installing

* Add reference to FancyPrint.dll in your .NET Project.
* You can also add the `FancyPrint` NuGet package from the CLI or your IDE.

### Usage

C# Example
```c#
        static void Main(string[] args)
        {
            // 1st parameter: Method to be printed inside []
            // 2nd parameter: Message to be displayed.
            FancyPrint.Print.WriteSuccess("Docs", "This worked!");
            FancyPrint.Print.WriteWarn("Docs", "This kinda worked!");
            FancyPrint.Print.WriteError("Docs", "This didn't work!");

            // Change method, success, warning, and error colors to anything you wish!
            FancyPrint.Colors.Method = ConsoleColor.Magenta;
            Console.WriteLine();
            FancyPrint.Print.WriteSuccess("Docs", "Now in purple!");
        }
```
![Screenshot 2021-10-28 130137](https://user-images.githubusercontent.com/8160191/139251745-b29752d9-3911-4515-9b30-8401d6b88c9f.png)

## Authors

[lewisdoesstuff](https://github.com/lewisdoesstuff)

## Version History

* 0.1
    * Initial Release

## License

This project is licensed under the MIT License - see the LICENSE.md file for details
