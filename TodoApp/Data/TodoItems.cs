using System;
using TodoApp.Model;

namespace TodoApp.Data
{
    public class TodoItems
    {

        private static Todo[] TodoArray = new Todo[] { };
        private static Todo[] DoneStatus = new Todo[] { };
        private static Todo[] AssigneeArray = new Todo[] { };
        private static Todo[] PersonAssigneeArray = new Todo[] { };
        private static Person[] UnassignedArray = new Person[] { };

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

            TodoArray.CopyTo(result, 0);
            result[TodoArray.Length] = newItem;

            return newItem;
        }

        public void Clear()
        {
            Array.Clear(TodoArray, 0, TodoArray.Length); 
        }

        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            
            foreach (Todo done in DoneStatus)
            {
                var check = Array.Exists(DoneStatus, doneStatus => doneStatus == done);
                if (check == true)
                {
                    Console.WriteLine("{0} found in the DoneStatus");
                    return done;
                }
            }
            Console.WriteLine("Value not found");
            return null;
        }

        public Todo[] FindByAssignee(int personId)
        {
            foreach (Todo assignee in AssigneeArray)
            {
                var check = Array.Exists(AssigneeArray, personId => personId == assignee);
                if (check == true)
                {
                    Console.WriteLine("{0} found in the AssigneeArray");
                    return assignee;
                }
            }

            Console.WriteLine("Value not found");

            return null;
        }

        public Todo[] FindByAssignee(Person assignee)
        {
            foreach (Todo personAssignee in PersonAssigneeArray)
            {
                var check = Array.Exists(PersonAssigneeArray, assignee => assignee == personAssignee);
                if (check == true)
                {
                    Console.WriteLine("{0} found in the PersonAssigneeArray");
                    return personAssignee;
                }
            }

            Console.WriteLine("Value not found");

            return null;
        }

        public Todo[] FindUnassignedTodoItems()
        {
            
            Item.Assignee = new Person();

            foreach (Person unassigned in UnassignedArray)
            {
                var check = Array.Exists(UnassignedArray, Item.Assignee => Item.Assignee != unassigned);
                if (check == true)
                {
                    Console.WriteLine("{0} found in the UnassignedArray");
                    return unassigned;
                }
            }

            Console.WriteLine("Value not found");

            return null;
        }
    }
}
