using System.Runtime.Intrinsics;
using TodoWithCommands.CommandsAndInterface;
using TodoWithCommands.Model;

namespace TodoWithCommands;

class Program
{
    public static void Main(string[] args)
    {
        WithoutCommands();
        WithCommandsAndInterface();
    }

    private static void WithoutCommands()
    {
        var todo = new TodoList();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Todo:");
            Console.WriteLine(todo.ListAsText());
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
                todo.Add(todoItem);
            }
            else if (cmd == "2")
            {
                Console.Write("Hvilket nr vil du slette? ");
                var noStr = Console.ReadLine();
                var no = Convert.ToInt32(noStr);
                var index = no - 1;
                todo.Delete(index);
            }
            else if (cmd == "3")
            {
                Console.Write("Hvilket nr vil du sette som utført? ");
                var noStr = Console.ReadLine();
                var no = Convert.ToInt32(noStr);
                var index = no - 1;
                todo.MarkAsDone(index);
            }
        }
    }

    private static void WithCommandsAndInterface()
    {
        var todo = new TodoList();
        var commands = new ICommand?[]
        {
            new AddTodoItemCommand(todo),
            new DeleteTodoItemCommand(todo),
            new MarkAsDoneCommand(todo)
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Todo:");
            Console.WriteLine(todo.ListAsText());
            Console.WriteLine("Kommandoer");
            foreach (var command in commands)
            {
                Console.WriteLine(command.Description);
            }

            var cmdNoStr = Console.ReadLine();
            var selectedCommand = CommandManager.Find(cmdNoStr, commands);
            if (selectedCommand != null)
            {
                selectedCommand.Run();
            }
            else
            {
                Console.WriteLine("Ukjent kommando: " + cmdNoStr);
            }
        }


    }
}

