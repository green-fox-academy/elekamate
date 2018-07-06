using ListingTodos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Services
{
    public class ToDoService : IToDoService
    {
        public List<ToDo> ToDosOfAssignee { get; set; }

        public List<ToDo> GetToDosOfAssignee()
        {
            return ToDosOfAssignee;
        }

        public void SetToDosOfAssignee(List<ToDo> input)
        {
            ToDosOfAssignee = input;
        }
    }
}
