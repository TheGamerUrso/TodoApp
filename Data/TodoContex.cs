using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Data
{
    public class TodoContex : DbContext
    {
        public TodoContex (DbContextOptions<TodoContex> options)
            : base(options)
        {
        }

        public DbSet<TodoApp.Models.Todo> Todo { get; set; } = default!;
    }
}
