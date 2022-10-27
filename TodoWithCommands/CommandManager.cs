using TodoWithCommands.CommandsAndInterface;

namespace TodoWithCommands
{
    internal class CommandManager
    {
        public static ICommand? Find(string cmdNoStr, ICommand?[] commands)
        {
            var cmdNo = Convert.ToInt32(cmdNoStr);
            foreach (var command in commands)
            {
                if (command.No == cmdNo)
                {
                    return command;
                }
            }
            return null;
        }
    }
}
