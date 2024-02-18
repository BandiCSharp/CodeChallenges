// See https://aka.ms/new-console-template for more information

using CodeChallenges;
using CommandLine;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
Parser.Default.ParseArguments(factory ,args)
                 .WithParsed(o =>
                 {
                     if (o.FileName is not null && o.CountLines is false && o.CountChars is false && o.WordCount is false && o.CountBytes is false)
                     {
                         Console.WriteLine($"{HandleInputs.CountLines(o)} {HandleInputs.WordCount}   {HandleInputs.CountBytes} {o.FileName ?? string.Empty}");

                     }
                     if (o.CountLines)
                     {
                         Console.WriteLine($"{HandleInputs.CountLines(o)} {o.FileName ?? string.Empty}");
                     }

                     if (o.WordCount)
                     {
                         Console.WriteLine($"{HandleInputs.WordCount} {o.FileName ?? string.Empty}");
                     }
                     if (o.CountBytes)
                     {
                        Console.WriteLine($"{HandleInputs.CountBytes} {o.FileName ?? string.Empty}");
                     }
                     if (o.CountChars)
                     {
                        Console.WriteLine($"{HandleInputs.CountChars} {o.FileName ?? string.Empty}");
                     }
                 }).WithNotParsed(e =>
                 {
                     Console.WriteLine(e.ToString());

                 });

static Options factory()
{
    var inputStream = Console.In.ReadToEnd();
    if (inputStream?.Length > 0)
    {
        Option.FileContent = inputStream;
        return Option;
    }
    return Option;
}

partial class Program
{
    [GeneratedRegex(@"\s+", RegexOptions.Multiline)]
    private static partial Regex MyRegex();
    private static Options Option = new();



}