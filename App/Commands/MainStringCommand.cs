using App.Extensions;
using McMaster.Extensions.CommandLineUtils;

namespace App.Commands
{
    [Command(Name = "string-cli", FullName = "String CLI", Description = "A string CLI tool.")]
    [HelpOption]
    [VersionOptionFromMember(MemberName = nameof(GetVersion))]
    [Subcommand(typeof(PalindromeStringCommand), typeof(ReverseStringCommand), typeof(SortStringCommand))]
    public class MainStringCommand
    {
        public void OnExecute(CommandLineApplication app)
        {
            app.ShowHelp();
        }

        private static string GetVersion() => typeof(MainStringCommand).GetVersion();
    }
}
