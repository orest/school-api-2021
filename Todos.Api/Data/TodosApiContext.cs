using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Todos.Api.Models;

    public class TodosApiContext : DbContext
    {
        public TodosApiContext (DbContextOptions<TodosApiContext> options)
            : base(options)
        {
        }

        public DbSet<Todos.Api.Models.Todo> Todo { get; set; }
    }
