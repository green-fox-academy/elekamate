using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingTodos.Models;
using ListingTodos.Repositories;
using ListingTodos.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ListingTodos.Controllers
{
    public class ToDoController : Controller
    {
        private ToDoContext toDoContextObj;
        public ToDoViewModel toDoViewModel = new ToDoViewModel();

        public ToDoController(ToDoContext toDoContext)
        {
            this.toDoContextObj = toDoContext;
        }

        public void Index()
        {
            Response.Redirect("/todo/list?isactive=true");
        }

        public IActionResult List(bool isActive, string searching)
        {
            IEnumerable<ToDo> filteredToDoDB = (isActive == true) ? toDoContextObj.ToDos.ToList().Where(toDo => toDo.IsDone == false) : toDoContextObj.ToDos.ToList();
            if (searching == null)
            {
                toDoViewModel.ToDos = filteredToDoDB.ToList();
            }
            else
            {
                toDoViewModel.ToDos = filteredToDoDB.Where(todo => todo.Title.Contains(searching)).ToList();
            }
            toDoViewModel.Assignees = toDoContextObj.Assignees.ToList();
            return View(toDoViewModel);
        }

        [HttpGet]
        public IActionResult AddToDo()
        {
            return View("addtodo", toDoContextObj.ToDos);
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

            toDoContextObj.ToDos.Add(toDoToAdd);
            toDoContextObj.SaveChanges();
            return Redirect("/todo/index");
        }

        [HttpPost]
        public IActionResult DeleteToDo(long toDoIDToDelete)
        {
            ToDo todoToDelete = toDoContextObj.ToDos.FirstOrDefault(todo => todo.Id == toDoIDToDelete);
            toDoContextObj.ToDos.Remove(todoToDelete);
            toDoContextObj.SaveChanges();
            return Redirect("/todo/index");
        }

        [HttpGet]
        public void ListToDosOfAssignee(long assigneeIdToFind)
        {
            toDoViewModel.ToDosOfAssignee = toDoViewModel.ToDos.Where(assignee => assignee.Id == assigneeIdToFind).ToList();
        }

        [HttpPost]
        public IActionResult ListToDosOfAssigneePost()
        {
            return View(toDoViewModel.ToDosOfAssignee);
        }
    }
}
