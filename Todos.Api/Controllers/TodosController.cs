﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Todos.Api.Models;

namespace Todos.Api.Controllers
{
    //[Route("api/[controller]")]
  
    [Route("api/todos")]

    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly TodosApiContext _context;

        public TodosController(TodosApiContext context)
        {
            _context = context;
        }


        //api/todos/3/category/5?orderBy=date 
        [HttpGet("{id}/category/{caregoryId}")]
        public async Task<ActionResult<string>> GetMyInfo(int id,int categoryId, string orderBy) {
           
            return "Orest";
        }



        // GET: api/Todos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Todo>>> GetTodo()
        {
            var todos = await _context.Todo.ToListAsync();
            return Ok(todos);
        }

        // GET: api/Todos/5
        [HttpGet("{id}",Name ="GetById")]
        public async Task<ActionResult<Todo>> GetTodo(int id)
        {
            var todo = await _context.Todo.FindAsync(id);

            if (todo == null)
            {
                return NotFound();
            }

            return Ok(todo);
        }

        // PUT: api/Todos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodo(int id, Todo todo)
        {
            if (id != todo.Id)
            {
                return BadRequest("Ids don't match");
            }

            _context.Entry(todo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Todos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Todo>> PostTodo(Todo todo)
        {
            _context.Todo.Add(todo);
            await _context.SaveChangesAsync();
            
            return CreatedAtAction("GetTodo", new { id = todo.Id }, todo);
            ///return CreatedAtRoute("GetById")
        }

        // DELETE: api/Todos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodo(int id)
        {
            var todo = await _context.Todo.FindAsync(id);
            if (todo == null)
            {
                return NotFound();
            }

            _context.Todo.Remove(todo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TodoExists(int id)
        {
            return _context.Todo.Any(e => e.Id == id);
        }
    }
}
