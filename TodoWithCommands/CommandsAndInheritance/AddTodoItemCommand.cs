using TodoWithCommands.Model;

namespace TodoWithCommands.CommandsAndInheritance
{
    internal class AddTodoItemCommand : Command
    {
        private readonly TodoList _todoList;

        public AddTodoItemCommand(TodoList todoList)
         : base("1", "legg til")
        {
            _todoList = todoList;
            _firstQuestion = "Hvor mange dager til fristen?";
        }

        public override void Run()
        {
            base.Run();
            var text = Ask("Hva skal gjøres?");
            var deadline = DateTime.Now.AddDays(_firstAnswer);
            var todoItem = new TodoItem(text, deadline);
            _todoList.Add(todoItem);
        }
    }
}
