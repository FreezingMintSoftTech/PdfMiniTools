﻿using System;
using System.Collections.Generic;
using System.Text;

using CommandLine;

namespace PdfInfo
{
    public class Options
    {

        [Option("a", "all", Required = false, HelpText = "Display all readable info. Setting this option will override -b and -f.")]
        public bool showAll = false;
        
        [Option("i", "info", Required = false, HelpText = "Display basic properties and info. This is the default.")]
        public bool showInfo = false; 

        [Option("c", "csv", Required = false, HelpText = "Output results in CSV format.")]
        public bool csvOutput = false;

        [Option("f", "fields", Required = false, HelpText = "Display form fields.")]
        public bool showFields = false;

        [Option("d", "debug", Required = false, HelpText = "Display details of any unhandled exceptions. Default is false.")]
        public bool debugMessages = false;


        [HelpOption(HelpText = "Display this help text.")]
        public String ShowUsage()
        {
            StringBuilder helpMessage = new StringBuilder();
            helpMessage.AppendLine("Usage:");
            helpMessage.AppendLine("\n   pdfinfo [-abf] file");
            helpMessage.AppendLine("\nExample 1:");
            helpMessage.AppendLine("\n   pdfinfo file1.pdf");
            helpMessage.AppendLine("\nShows basic PDF properties for file1.pdf (\"pdfinfo -b file1.pdf\" is equivalent).");
            helpMessage.AppendLine("\nExample 2:");
            helpMessage.AppendLine("\n   pdfinfo -a file1.pdf");
            helpMessage.AppendLine("\nShows all readable info for file1.pdf");
            helpMessage.AppendLine("\nExample 3:");
            helpMessage.AppendLine("\n   pdfinfo -cf file1.pdf");
            helpMessage.AppendLine("\nShows form fields for file1.pdf in comma separated (csv) format.");

            return helpMessage.ToString();
        }

        [ValueList(typeof(List<string>))]
        public IList<string> Items = null;

    }
}
