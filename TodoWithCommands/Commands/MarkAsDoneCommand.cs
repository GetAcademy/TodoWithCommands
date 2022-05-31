using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoWithCommands.Model;

namespace TodoWithCommands.Commands
{
    internal class MarkAsDoneCommand
    {
        private readonly TodoManager _todo;

        public MarkAsDoneCommand(TodoManager todo)
        {
            _todo = todo;
        }

        public void Run()
        {
            Console.Write("Hvilket nr vil du sette som utført? ");
            var noStr = Console.ReadLine();
            var no = Convert.ToInt32(noStr);
            var index = no - 1;
            _todo.MarkAsDone(index);
        }
    }
}
