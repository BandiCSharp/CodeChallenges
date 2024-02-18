using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace CodeChallenges
{
    class Options
    {
        [Option('m', "lines", Required = false, HelpText = "Count characters.")]
        public bool CountChars { get; set; }

        [Option('l', "lines", Required = false, HelpText = "Count lines.")]
        public bool CountLines { get; set; }

        [Option('w', "words", Required = false, HelpText = "Count words.")]
        public bool WordCount { get; set; }

        [Option('c', "bytes", Required = false, HelpText = "Count bytes.")]
        public bool CountBytes { get; set; }
        
        [Value(0, MetaName = "file", HelpText = "Input file.")]
        public string? FileName { get; set; }

        [Value(1, MetaName = "file", HelpText = " file Content.",Hidden = true)]
        public string? FileContent { get; set; }
    }
}
