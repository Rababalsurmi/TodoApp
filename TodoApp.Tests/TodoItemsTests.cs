using System;
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
            int todoId = 1;

            TodoItems testFindById = new TodoItems();

            Todo actual = testFindById.FindById(todoId);

            Assert.Equal(Item, actual);
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

            Todo todo = new Todo();
            bool doneStatus = true;

            TodoItems testFindByDoneStatus = new TodoItems();

            Todo actual = testFindByDoneStatus.FindByDoneStatus(doneStatus);

            Assert.Equal(todo, actual);
        }

        [Fact]
        public void FindByAssigneeTest()
        {

            Todo Assignee = new Todo();
            int personId = 1;

            TodoItems testFindByAssignee = new TodoItems();

            Todo actual = testFindByAssignee.FindByAssignee(personId);

            Assert.Equal(Assignee, actual);
        }

        [Fact]
        public void FindByPersonAssigneeTest()
        {

            Todo PersonAssignee = new Todo();
            Person assignee;

            TodoItems testFindByAssignee = new TodoItems();

            Todo actual = testFindByAssignee.FindByAssignee(assignee);

            Assert.Equal(PersonAssignee, actual);
        }
    }
}
