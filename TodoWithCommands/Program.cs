using TodoWithCommands.Commands;
using TodoWithCommands.Model;

var todo = new TodoManager();
var cmd1 = new AddTodoItemCommand(todo);
var cmd2 = new DeleteTodoItemCommand(todo);
var cmd3 = new MarkAsDoneCommand(todo);

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
    if (cmd == "1") cmd1.Run();
    else if (cmd == "2") cmd2.Run();
    else if (cmd == "3") cmd3.Run();
}

