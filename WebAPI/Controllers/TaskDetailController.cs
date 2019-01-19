using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskDetailController : ControllerBase
    {
        private readonly TaskDetailContext _context;

        public TaskDetailController(TaskDetailContext context)
        {
            _context = context;
        }

        // GET: api/TaskDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskDetail>>> GetTaskDetails()
        {
            return await _context.TaskDetails.ToListAsync();
        }

        // GET: api/TaskDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskDetail>> GetTaskDetail(int id)
        {
            var taskDetail = await _context.TaskDetails.FindAsync(id);

            if (taskDetail == null)
            {
                return NotFound();
            }

            return taskDetail;
        }

        // PUT: api/TaskDetail/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaskDetail(int id, TaskDetail taskDetail)
        {
            if (id != taskDetail.TaskId)
            {
                return BadRequest();
            }

            _context.Entry(taskDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskDetailExists(id))
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

        // POST: api/TaskDetail
        [HttpPost]
        public async Task<ActionResult<TaskDetail>> PostTaskDetail(TaskDetail taskDetail)
        {
            _context.TaskDetails.Add(taskDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTaskDetail", new { id = taskDetail.TaskId }, taskDetail);
        }

        // DELETE: api/TaskDetail/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TaskDetail>> DeleteTaskDetail(int id)
        {
            var taskDetail = await _context.TaskDetails.FindAsync(id);
            if (taskDetail == null)
            {
                return NotFound();
            }

            _context.TaskDetails.Remove(taskDetail);
            await _context.SaveChangesAsync();

            return taskDetail;
        }

        private bool TaskDetailExists(int id)
        {
            return _context.TaskDetails.Any(e => e.TaskId == id);
        }
    }
}
