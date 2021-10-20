using System;
using System.Collections.Generic;
using System.Linq;
using TodoService.Models;

namespace TodoService.Data
{
    public class MockTodoItemData : ITodoItemData
    {
        private List<TodoItem> todoItems = new List<TodoItem>() {
            new TodoItem{ Id = Guid.NewGuid(), Text="Test", IsCompleted=false }
        };

        public TodoItem Add(TodoItem todoItem)
        {
            todoItem.Id = Guid.NewGuid();
            todoItems.Add(todoItem);
            return todoItem;
        }

        public void Delete(Guid id)
        {
            var existingTodoItem = Get(id);

            todoItems.Remove(existingTodoItem);
        }

        public TodoItem Edit(TodoItem todoItem)
        {
            var existingTodoItem = Get(todoItem.Id);
            existingTodoItem.Text = todoItem.Text;
            existingTodoItem.IsCompleted = todoItem.IsCompleted;
            return existingTodoItem;
        }

        public TodoItem Get(Guid id)
        {
            return todoItems.FirstOrDefault(x => x.Id == id);
        }

        public List<TodoItem> GetTodoItems()
        {
            return todoItems;
        }
    }
}
