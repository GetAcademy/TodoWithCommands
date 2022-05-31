using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoWithCommands
{
    internal class OldProgram
    {
        /*
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

         
         */
    }
}
