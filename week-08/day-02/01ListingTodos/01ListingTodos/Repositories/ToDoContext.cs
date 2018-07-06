using ListingTodos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Repositories
{
    public class ToDoContext : DbContext
    {
        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<Assignee> Assignees { get; set; }
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {
        }
    }
}
