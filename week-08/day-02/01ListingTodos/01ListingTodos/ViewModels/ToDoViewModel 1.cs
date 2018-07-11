using ListingTodos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.ViewModels
{
    public class ToDoViewModel
    {
        public List<ToDo> ToDos { get; set; }
        public List<Assignee> Assignees { get; set; }
        public List<ToDo> ToDosOfAssignee { get; set; }
    }
}
