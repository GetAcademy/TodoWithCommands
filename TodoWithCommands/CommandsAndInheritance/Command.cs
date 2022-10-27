namespace TodoWithCommands.CommandsAndInheritance
{
    internal class Command
    {
        public string No { get; }
        public string Description { get; }

        protected string _firstQuestion;
        protected int _firstAnswer;

        public Command(string no, string description)
        {
            No = no;
            Description = no + " - " + description;
        }

        public virtual void Run()
        {
            Console.WriteLine("Du valgte: " + Description);
            _firstAnswer = AskForInt(_firstQuestion);
        }

        protected static string Ask(string question)
        {
            Console.Write(question + " ");
            return Console.ReadLine();
        }

        protected static int AskForInt(string question)
        {
            return Convert.ToInt32(Ask(question));
        }
    }
}
