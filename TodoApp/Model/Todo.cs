using System;
namespace TodoApp.Model
{
    public class Todo
    {
        //id
        static int idCounter = 0;
        public static int IdCounter { get { return idCounter; } }

        private readonly int todoId;
        public int Id { get { return todoId; } }

        //description
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

        //status
        private bool done;
        public bool Done
        {
            get { return done; }
            set { done = value; }
        }

        //assigned person
        private Person assignee = new Person();
        public Person Assignee
        {
            get { return assignee; }
            set { assignee = value; }
        }

        //constructor
        public Todo()
        {
            todoId = ++idCounter;
            this.description = "";
            //assignee = new Person("Tom", "Smith");
            //this.done = true;  
        }

        public Todo(int todoId, String description)
        {
            this.todoId = todoId;
            this.description = description;
            //assignee = new Person("Maria", "Anniston");
            //this.done = true;  
        }

        public string TodoInformation()
        {
            return $"Todo Information\n" +
                $"id: {todoId}\n" +
                $"Assignee: {assignee.FirstName} {assignee.LastName}\n" +
                $"Description: {description}\n"+
                $"Done: {done}\n";
        }
    }
}
