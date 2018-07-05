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
            Response.Redirect("/todo/list?isactive=true");
        }

        public IActionResult List(bool isActive, string searching)
        {
            IEnumerable<ToDo> filteredToDoDB = (isActive == true) ? toDoContext.ToDos.ToList().Where(toDo => toDo.IsDone == false) : toDoContext.ToDos.ToList();
            if (searching == null)
            {
                return View(filteredToDoDB.ToList());
            }
            else
            {
                return View(filteredToDoDB.Where(todo => todo.Title.Contains(searching)).ToList());
            }
        }

        [HttpGet]
        public IActionResult AddToDo()
        {
            return View("addtodo", toDoContext.ToDos);
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

            toDoContext.ToDos.Add(toDoToAdd);
            toDoContext.SaveChanges();
            return Redirect("/todo/index");
        }

        [HttpPost]
        public IActionResult DeleteToDo(long toDoIDToDelete)
        {
            ToDo todoToDelete = toDoContext.ToDos.FirstOrDefault(todo => todo.Id == toDoIDToDelete);
            toDoContext.ToDos.Remove(todoToDelete);
            toDoContext.SaveChanges();
            return Redirect("/todo/index");
        }
    }
}
