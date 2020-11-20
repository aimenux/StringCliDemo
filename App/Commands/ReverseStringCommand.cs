using App.Extensions;
using McMaster.Extensions.CommandLineUtils;
using System;
using System.ComponentModel.DataAnnotations;

namespace App.Commands
{
    [Command(Name = "ReverseStringCli", FullName = "ReverseString CLI", Description = "A ReverseString CLI Tool.")]
    [VersionOptionFromMember(MemberName = nameof(GetVersion))]
    [HelpOption]
    public class ReverseStringCommand
    {
        [Required]
        [Argument(0, "Text", "Some text to reverse")]
        public string Text { get; set; }

        public void OnExecute(CommandLineApplication app)
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                app.ShowHelp();
                return;
            }

            ConsoleColor.Magenta.WriteLine(Text.Reverse());
        }

        private static string GetVersion() => typeof(ReverseStringCommand).GetVersion();
    }
}
