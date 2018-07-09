using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingTodos.Models;
using ListingTodos.Repositories;
using ListingTodos.Services;
using ListingTodos.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ListingTodos.Controllers
{
    public class ToDoController : Controller
    {
        private ToDoContext toDoContextObj;
        private IToDoService toDoServiceObj;
        private ToDoViewModel toDoViewModel;

        public ToDoController(ToDoContext toDoContext, IToDoService toDoService)
        {
            toDoContextObj = toDoContext;
            toDoServiceObj = toDoService;
            toDoViewModel = new ToDoViewModel();
        }

        public void Index()
        {
            Response.Redirect("/todo/list?isactive=true");
        }

        [HttpGet]
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
        [Route("/ToDo/{toDoIDToEdit}/EditToDo")]
        public IActionResult EditToDo(long toDoIDToEdit)
        {
            return View(toDoContextObj.ToDos.FirstOrDefault(todo => todo.Id == toDoIDToEdit));
        }

        //[HttpPost]
        //[Route("/ToDo/{toDoIDToEdit}/EditToDo")]
        //public void EditToDoPost(long toDoIDToEdit)
        //{
        //    Redirect("/ToDo/{toDoToEdit}/EditToDo");
        //}

        [HttpGet]
        public IActionResult ListToDosOfAssignee()
        {
            return View(toDoServiceObj.GetToDosOfAssignee());
        }

        [HttpPost]
        public IActionResult ListToDosOfAssigneePost(long assigneeIdToFind)
        {
            toDoServiceObj.SetToDosOfAssignee(toDoContextObj.ToDos.Where(todo => todo.Assignee.Id == assigneeIdToFind).ToList());
            return Redirect("/ToDo/ListToDosOfAssignee");
        }
    }
}
