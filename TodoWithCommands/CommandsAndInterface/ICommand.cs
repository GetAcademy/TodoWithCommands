namespace TodoWithCommands.CommandsAndInterface
{
    internal interface ICommand
    {
        void Run();
        string No { get; }
        string Description { get; }
    }
}
