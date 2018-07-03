using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingTodos.Models;
using ListingTodos.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ListingTodos.Controllers
{
    public class ToDoController : Controller
    {
        private ToDoContext toDoContext;

        public ToDoController(ToDoContext toDoContext)
        {
            this.toDoContext = toDoContext;
        }

        public void Index()
        {
            Response.Redirect("list?isactive=true");
        }

        public IActionResult List(bool IsActive)
        {
            IEnumerable<ToDo> filteredToDoDB = (IsActive == true) ? toDoContext.ToDos.ToList().Where(toDo => toDo.IsDone == false) : toDoContext.ToDos.ToList();
            return View(filteredToDoDB.ToList());
        }

        [HttpGet]
        public IActionResult AddToDo()
        {
            return View("AddToDo", toDoContext.ToDos);
        }

        [HttpPost]
        public IActionResult PostToDo(string toDoTitle)
        {
            ToDo toDoToAdd = new ToDo()
            {
                Title = toDoTitle,
                IsUrgent = false,
                IsDone = false,
            };
            return Redirect("index");
        }
    }
}