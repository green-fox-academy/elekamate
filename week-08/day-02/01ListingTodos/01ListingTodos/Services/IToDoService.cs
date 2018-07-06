using ListingTodos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Services
{
    public interface IToDoService
    {
        List<ToDo> GetToDosOfAssignee();
        void SetToDosOfAssignee(List<ToDo> input);
    }
}
