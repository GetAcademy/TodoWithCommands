using TodoWithCommands.CommandsAndInterface;
using TodoWithCommands.Model;

namespace TodoWithCommands;

class Program
{
    public static void Main(string[] args)
    {
        //WithoutCommands();
        WithCommandsAndInterface();
    }

    private static void WithoutCommands()
    {
        var todoList = new TodoList();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Todo:");
            Console.WriteLine(todoList.ListAsText());
            Console.WriteLine("Kommandoer");
            Console.WriteLine("1 - legg til");
            Console.WriteLine("2 - slett");
            Console.WriteLine("3 - marker som utført");

            var cmd = Console.ReadLine();
            if (cmd == "1")
            {
                Console.WriteLine("Legg til");
                Console.Write("Hvor mange dager til fristen? ");
                var deadlineDaysStr = Console.ReadLine();
                var deadlineDays = Convert.ToInt32(deadlineDaysStr);
                Console.Write("Hva skal gjøres? ");
                var text = Console.ReadLine();
                var todoItem = new TodoItem(text, DateTime.Now.AddDays(deadlineDays));
                todoList.Add(todoItem);
            }
            else if (cmd == "2")
            {
                Console.Write("Hvilket nr vil du slette? ");
                var noStr = Console.ReadLine();
                var no = Convert.ToInt32(noStr);
                var index = no - 1;
                todoList.Delete(index);
            }
            else if (cmd == "3")
            {
                Console.Write("Hvilket nr vil du sette som utført? ");
                var noStr = Console.ReadLine();
                var no = Convert.ToInt32(noStr);
                var index = no - 1;
                todoList.MarkAsDone(index);
            }
        }
    }

    private static void WithCommandsAndInterface()
    {
        var todoList = new TodoList();
        var commands = new ICommand[]
        {
            new AddTodoItemCommand(todoList),
            new DeleteTodoItemCommand(todoList),
            new MarkAsDoneCommand(todoList)
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Todo:");
            Console.WriteLine(todoList.ListAsText());
            Console.WriteLine("Kommandoer");
            foreach (var command in commands)
            {
                Console.WriteLine(command.Description);
            }

            var cmdNo = Console.ReadLine();
            var selectedCommand = commands.SingleOrDefault(cmd => cmd.No == cmdNo);
            selectedCommand?.Run();
        }
    }
}

