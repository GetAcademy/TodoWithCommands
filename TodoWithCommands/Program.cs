using TodoWithCommands.Model;

var todo = new TodoManager();

while (true)
{
    Console.Clear();
    Console.WriteLine("Todo:");
    Console.WriteLine(todo.ListAsText());
    Console.WriteLine("Kommandoer");
    Console.WriteLine("1 - legg til");
    Console.WriteLine("2 - slett");

    var cmd = Console.ReadLine();
    if (cmd == "1")
    {
        Console.WriteLine("Legg til");
        Console.Write("Hvor mange dager til fristen? ");
        var deadlineDaysStr = Console.ReadLine();
        var deadlineDays = Convert.ToInt32(deadlineDaysStr);
        Console.Write("Hva skal gjøres? ");
        var text = Console.ReadLine();
        todo.Add(new TodoItem(text, DateTime.Now.AddDays(deadlineDays)));

    }
    else if (cmd == "2")
    {
        Console.Write("Hvilket nr vil du slette? ");
        var noStr = Console.ReadLine();
        var no = Convert.ToInt32(noStr);
        var index = no - 1;
        todo.Delete(index);
    }
}

