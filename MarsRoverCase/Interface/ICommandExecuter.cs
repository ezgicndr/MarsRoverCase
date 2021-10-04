using System.Text.RegularExpressions;

namespace MarsRoverCase.Interface
{
    public interface ICommandExecuter
    {
        Regex RegexCommandPattern { get; }
        void ExecuteCommand(string command);
        bool MatchCommand(string command);
    }
}