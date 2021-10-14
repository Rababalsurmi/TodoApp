using System;
using TodoApp.Model;

namespace TodoApp.Data
{
    public class TodoItems
    {

        private static Todo[] TodoArray = new Todo[] { };

        TodoSequencer newItem = new TodoSequencer();
        Todo Item = new Todo();

        public int Size(Todo[] TodoArray)
        {
            return TodoArray.Length;
        }

        public Todo[] FindAll(Todo[] TodoArray)
        {
            return TodoArray;
        }

        public Todo FindById(int todoId)
        {
            foreach (Todo item in TodoArray)
            {
                var check = Array.Exists(TodoArray, todoId => todoId == item);
                if (check == true)
                {
                    Console.WriteLine("{0} found in the array");
                    return item;
                }
            }

            Console.WriteLine("Value not found");

            return null;
        }

        public static Todo NewItem(String description)
        {
            int todoId = 0;
            todoId = TodoSequencer.nextTodo();

            Todo newItem = new Todo(todoId, description);


            Array.Resize(ref TodoArray, TodoArray.Length + 1);

            Todo[] result = new Todo[TodoArray.Length + 1];

            for (int i = 0; i < TodoArray.Length; i++)
            {
                int x = 5;
                if (i < x - 1)
                    result[i] = TodoArray[i];
                else if (i == x - 1)
                    result[i] = newItem;
                else
                    result[i] = TodoArray[i - 1];
            }
            return newItem;
        }

        public void Clear()
        {
            Array.Clear(TodoArray, 0, TodoArray.Length);

            //Todo[] TodoArray = Array.Empty<Todo>();
        }
    }
}
