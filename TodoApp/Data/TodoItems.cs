using System;
using System.Collections.Generic;
using System.Linq;
using TodoApp.Model;

namespace TodoApp.Data
{
    public class TodoItems
    {

        private static Todo[] TodoArray = new Todo[] { };
        
        private static Todo[] AssigneeArray = new Todo[] { };
        private static Todo[] PersonAssigneeArray = new Todo[] { };
        private static Todo[] UnassignedArray = new Todo[] { };

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
            Todo Item = new Todo();
            List<Todo> TodoIdArray = new List<Todo>();
            foreach (Todo todo in TodoArray)
            {
                //var check = Array.Exists(TodoArray, todoId => todoId == item);
                if (todo.Id == todoId)
                {
                    Console.WriteLine("found in the DoneStatus");
                    return todo;
                }
                else
                {
                    break;
                }
            }
            
            return Item;

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
            List<Todo> DoneStatus = new List<Todo>();

            foreach (Todo todo in TodoArray)
            {
                if (todo.Done == doneStatus)
                {
                    DoneStatus.Add(todo);
                }
                else
                {
                    break;  
                }
            }

            Console.WriteLine("found in the DoneStatus");
            return DoneStatus.ToArray() ;  
        }

        public Todo[] FindByAssignee(int personId)
        {
            List<Todo> AssigneeArray = new List<Todo>();

            foreach (Todo todo in TodoArray)
            {
                //var check = Array.Exists(AssigneeArray, personId => personId == assignee);
                if (todo.Id == personId)
                {
                    AssigneeArray.Add(todo);
                    
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("found in the AssigneeArray");

            return AssigneeArray.ToArray();
        }

        public Todo[] FindByAssignee(Person assignee)
        {
            List<Todo> PersonAssigneeArray = new List<Todo>();

            foreach (Todo todo in TodoArray)
            {
                //var check = Array.Exists(PersonAssigneeArray, assignee => assignee == personAssignee);
                if (todo.Assignee == assignee)
                {
                    PersonAssigneeArray.Add(todo);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("found in the PersonAssigneeArray");
            return PersonAssigneeArray.ToArray();
        }

        public Todo[] FindUnassignedTodoItems()
        {
            List<Todo> UnassignedArray = new List<Todo>();

            //Item.Assignee = new Person();

            foreach (Todo todo in TodoArray)
            {
                //var check = Array.Exists(UnassignedArray, Item.Assignee => Item.Assignee != unassigned);
                if (todo.Assignee == null)
                {
                    UnassignedArray.Add(todo);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("{0} found in the UnassignedArray");
            return UnassignedArray.ToArray();
        }

        public void Remove(int indexToRemove)
        {
            TodoArray = TodoArray.Where((source, index) => index != indexToRemove).ToArray();
        }
    }
}
