using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeChallenges
{
    internal partial struct HandleInputs
    {

        public static int CountLines(Options options)
        {
            if (options.FileContent?.Length == 0 || File.Exists(options.FileName) is false)
            {
                return 0;
            }
            string[]? inputLines = options.FileContent?.Trim()?.ToLowerInvariant()?.Split('\n') ?? File.ReadAllLines(options.FileName) ?? [];
            return inputLines.Length;
        }

        public static int WordCount(Options options)
        {
            if (options.FileContent?.Length == 0 || File.Exists(options.FileName) is false)
            {
                return 0;
            }
            return MyRegex().Count(options.FileContent ?? File.ReadAllText(options.FileName));
        }

        public static int CountBytes(Options options)
        {
            if (options.FileContent?.Length == 0 || File.Exists(options.FileName) is false)
            {
                return 0;
            }
            var byteCount = UTF8Encoding.ASCII.GetByteCount(options.FileContent ?? string.Empty);
            return byteCount == 0 ? File.ReadAllBytes(options.FileName).Length : byteCount;
        }

        public static int CountChars(Options options)
        {
            if (options.FileContent?.Length == 0 || File.Exists(options.FileName) is false)
            {
                return 0;
            }
            return options.FileContent?.Length ?? File.ReadAllText(options.FileName).Length;
        }
        [GeneratedRegex(@"\s+", RegexOptions.Multiline)]
        private static partial Regex MyRegex();
    }
}
