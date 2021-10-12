using System;
namespace TodoApp.Data
{
    public class TodoSequencer
    {
        private static int todoId = 0;
        public int todoID { get { return todoId; } }

        public static int nextTodo()
        {
            int todoID = todoId;
            return ++todoID;
        }

        public static int resetTodoId()
        {
            int todoId = 0;
            int Id = todoId;
            return Id;
        }
    }
}
