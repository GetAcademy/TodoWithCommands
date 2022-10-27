using TodoWithCommands.Model;

namespace TodoWithCommands.CommandsAndInheritance
{
    internal class MarkAsDoneCommand : Command
    {
        private readonly TodoList _todoList;

        public MarkAsDoneCommand(TodoList todoList)
            : base("3", "marker som gjort")
        {
            _todoList = todoList;
            _firstQuestion = "Hvilket nr vil du sette som utført?";
        }

        public override void Run()
        {
            base.Run();
            _todoList.MarkAsDone(_firstAnswer - 1);
        }
    }
}
