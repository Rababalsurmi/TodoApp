using System;
using System.Collections.Generic;
using Xunit;
using TodoApp.Data;
using TodoApp.Model;

namespace TodoApp.Tests
{
    public class TodoItemsTests
    {
        [Fact]
        public void SizeTest()
        {
            Todo[] TodoArray = new Todo[] { };

            TodoItems testSize = new TodoItems();

            var actual = testSize.Size(TodoArray);

            Assert.Equal(0, actual);
        }

        [Fact]
        public void FindAllTest()
        {
            Todo[] TodoArray = new Todo[] { };

            TodoItems testFindAll = new TodoItems();

            var actual = testFindAll.FindAll(TodoArray);

            Assert.Equal(TodoArray, actual);

        }

        [Fact]
        public void FindByIdTest()
        {

            Todo Item = new Todo();
            int todoId = 0;

            TodoItems testFindById = new TodoItems();

            Todo actual = testFindById.FindById(todoId);

            //Assert.Equal(Item, actual);
            Assert.Equal(Item.Id, todoId);
        }

        [Fact]
        public void NewItemTest()
        {
            String description = "Kampanj";
            int todoId = 1;


            Todo newItem = new Todo(todoId, description);


            Todo actual = TodoItems.NewItem(description);


            //Assert.Equal(newItem, actual);
            Assert.NotNull(newItem);
            Assert.Equal(newItem.Id, todoId);
            Assert.Equal(newItem.Description, description);
           
        }
      
        [Fact]
        public void ClearTest()
        {
            Todo[] TodoArray = new Todo[] { };

            TodoItems testClear = new TodoItems();

            testClear.Clear();

            Assert.Empty(TodoArray);

        }

        [Fact]
        public void FindByDoneStatusTest()
        {
            Todo[] DoneStatus = new Todo[] { };
            Todo todo = new Todo();
            bool doneStatus = true;

            TodoItems testFindByDoneStatus = new TodoItems();

            var actual = testFindByDoneStatus.FindByDoneStatus(doneStatus);

            Assert.Equal(DoneStatus, actual);
        }

        [Fact]
        public void FindByAssigneeTest()
        {
            Todo[] AssigneeArray = new Todo[] { };
            Todo todo = new Todo();

            int personId = 1;

            TodoItems testFindByAssignee = new TodoItems();

            var actual = testFindByAssignee.FindByAssignee(personId);

            Assert.Equal(AssigneeArray, actual);
        }

        [Fact]
        public void FindByPersonAssigneeTest()
        {
            Todo[] PersonAssigneeArray = new Todo[] { };
            Todo todo = new Todo();

            Person assignee = new Person("Karl", "Karlsson");

            TodoItems testFindByAssignee = new TodoItems();

            var actual = testFindByAssignee.FindByAssignee(assignee);

            Assert.Equal(PersonAssigneeArray, actual);
        }

        [Fact]
        public void FindUnassignedTodoItemsTest()
        {
            Todo[] UnassignedArray = new Todo[] { };

            TodoItems testFindUnassignedTodoItems = new TodoItems();

            var actual = testFindUnassignedTodoItems.FindUnassignedTodoItems();

            Assert.Equal(UnassignedArray, actual);
        }

        [Fact]
        public void RemoveTest()
        {
            int indexToRemove = 0;
            Todo[] TodoArray = new Todo[] { };

            TodoItems testRemove = new TodoItems();

            testRemove.Remove(indexToRemove);

            Assert.NotNull(TodoArray);

        }
    }
}
