using App.Extensions;
using McMaster.Extensions.CommandLineUtils;
using System;
using System.ComponentModel.DataAnnotations;

namespace App.Commands
{
    [Command(Name = "SortStringCli", FullName = "SortString CLI", Description = "A SortString CLI Tool.")]
    [VersionOptionFromMember(MemberName = nameof(GetVersion))]
    [HelpOption]
    public class SortStringCommand
    {
        [Required]
        [Argument(0, "Text", "Some text to sort")]
        public string Text { get; set; }

        public void OnExecute(CommandLineApplication app)
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                app.ShowHelp();
                return;
            }

            ConsoleColor.Magenta.WriteLine(Text.Sort());
        }

        private static string GetVersion() => typeof(SortStringCommand).GetVersion();
    }
}
