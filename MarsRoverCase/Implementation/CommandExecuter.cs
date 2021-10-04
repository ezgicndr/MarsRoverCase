using MarsRoverCase.Interface;
using System.Text.RegularExpressions;

namespace MarsRoverCase.Implementation
{
    public abstract class CommandExecuter : ICommandExecuter
    {
        public abstract Regex RegexCommandPattern { get; }

        public abstract void ExecuteCommand(string command);

        public bool MatchCommand(string command)
        {
            return RegexCommandPattern.IsMatch(command);
        }
    }
}