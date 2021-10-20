using System;
using System.Collections.Generic;
using TodoService.Models;

namespace TodoService.Data
{
    public interface ITodoItemData
    {
        TodoItem Add(TodoItem todoItem);
        TodoItem Edit(TodoItem todoItem);
        List<TodoItem> GetTodoItems();
        void Delete(Guid id);
        TodoItem Get(Guid id);
    }
}
