using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoService.Data;
using TodoService.Models;

namespace TodoService.Controllers
{
    [ApiController]
    public class TodoController : ControllerBase
    {
        ITodoItemData _todoItemData;

        public TodoController(ITodoItemData todoItemData)
        {
            _todoItemData = todoItemData;
        }

        [HttpGet]
        [Route("api/[controller]/")]
        public ActionResult GetTodoItems()
        {
            return Ok(_todoItemData.GetTodoItems());
        }

        [HttpPost]
        [Route("api/[controller]/")]
        public ActionResult AddTodoItem(TodoItem todoItem)
        {
            return Ok(_todoItemData.Add(todoItem));
        }

        [HttpDelete]
        [Route("api/[controller]/{0}")]
        public ActionResult DeleteTodoItem(Guid id)
        {
            _todoItemData.Delete(id);

            return Ok();
        }

        [HttpPatch]
        [Route("api/[controller]/{0}")]
        public ActionResult EditTodoItem(Guid id, TodoItem todoItem)
        {
            var existingTodoItem = _todoItemData.Get(id);

            if (existingTodoItem != null)
            {
                _todoItemData.Edit(todoItem);

                return Ok();
            }

            return NotFound();
        }
    }
}
