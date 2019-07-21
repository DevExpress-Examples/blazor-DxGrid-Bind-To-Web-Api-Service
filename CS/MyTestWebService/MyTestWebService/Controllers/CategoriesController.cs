using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyTestWebService.Models;
using Microsoft.EntityFrameworkCore;

namespace MyTestWebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly NWINDContext _context;

        public CategoriesController(NWINDContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categories>>> Get()
        {
            return await _context.Categories.ToListAsync();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Categories>> Get(int id)
        {
            var todoItem = await _context.Categories.FindAsync(id);
            if (todoItem == null) {
                return NotFound();
            }
            return todoItem;
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult<Categories>> Post(Categories item)
        {
            _context.Categories.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = item.CategoryId }, item);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Categories item)
        {
            if (id != item.CategoryId) {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var todoItem = await _context.Categories.FindAsync(id);
            if (todoItem == null) {
                return NotFound();
            }
            _context.Categories.Remove(todoItem);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
