using TodoWithCommands.Model;

namespace TodoWithCommands.CommandsAndInheritance
{
    internal class DeleteTodoItemCommand : Command
    {
        private readonly TodoList _todoList;
        public DeleteTodoItemCommand(TodoList todoList)
            : base("2", "slett")
        {
            _todoList = todoList;
            _firstQuestion = "Hvilket nr vil du slette?";
        }

        public override void Run()
        {
            base.Run();
            _todoList.Delete(_firstAnswer - 1);
        }
    }
}
