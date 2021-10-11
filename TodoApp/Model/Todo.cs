using System;
namespace TodoApp.Model
{
    public class Todo
    {
        static int idCounter = 0;
        public static int IdCounter { get { return idCounter; } }

        private readonly int todoId;
        public int Id { get { return todoId; } }

        private String description;
        public String Description
        {
            get { return description; }
            set
            {
                if (value.Equals(""))
                {
                    throw new ArgumentException("Invaild Description! ");
                }
                description = value;
            }
        }

        private bool done;
        public bool Done { get { return done; } }

        private Person assignee = new Person("Tom", "Smith");
        public Person Assignee
        {
            get { return assignee; }
            set { assignee = value; }
        }

        public Todo()
        {
            todoId = ++idCounter;
            this.description = "Create a calculator App";
            assignee = new Person("Tom", "Smith");
            this.done = true;
            
        }

        public Todo(int todoId, String description)
        {
            this.todoId = todoId;
            this.description = description;
            assignee = new Person("Maria", "Anniston");
            this.done = true;
            
        }

        public string Information()
        {
            return $"Todo Information\n" +
                $"id: {todoId}\n" +
                $"Assignee: {assignee}\n" +
                $"Description: {description}\n"+
                $"Status: {done}\n";
        }
    }
}
