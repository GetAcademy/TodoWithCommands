using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoWithCommands.Model;

namespace TodoWithCommands.Commands
{
    internal class DeleteTodoItemCommand
    {
        private readonly TodoManager _todo;

        public DeleteTodoItemCommand(TodoManager todo)
        {
            _todo = todo;
        }

        public void Run()
        {
            Console.Write("Hvilket nr vil du slette? ");
            var noStr = Console.ReadLine();
            var no = Convert.ToInt32(noStr);
            var index = no - 1;
            _todo.Delete(index);
        }
    }
}
