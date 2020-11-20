using App.Extensions;
using McMaster.Extensions.CommandLineUtils;
using System;
using System.ComponentModel.DataAnnotations;

namespace App.Commands
{
    [Command(Name = "PalindromeStringCli", FullName = "PalindromeString CLI", Description = "A PalindromeString CLI Tool.")]
    [VersionOptionFromMember(MemberName = nameof(GetVersion))]
    [HelpOption]
    public class PalindromeStringCommand
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

            if (Text.IsPalindrome())
            {
                ConsoleColor.Magenta.WriteLine($"'{Text}' is a palindrome.");
            }
            else
            {
                ConsoleColor.Yellow.WriteLine($"'{Text}' is not a palindrome.");
            }
        }

        private static string GetVersion() => typeof(PalindromeStringCommand).GetVersion();
    }
}
