using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sdaemon.DAL;
using Sdaemon.Model;

namespace Sdaemon.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly TaskDbContext _context;
        public TaskController(TaskDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetAllTask")]
        public async Task<ActionResult<IEnumerable<TaskItem>>> GetTasks() =>
            await _context.Tasks.ToListAsync();

        [HttpGet]
        [Route("SelectByIdTask/{id}")]
        public async Task<ActionResult<TaskItem>> GetTask(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            return task == null ? NotFound(new { error = "Task not found" }) : Ok(task);
        }

        [HttpPost]
        [Route("InsertTask")]
        public async Task<ActionResult<TaskItem>> InsertTask([FromBody] TaskItem task)
        {
            if (string.IsNullOrWhiteSpace(task.Title))
                return BadRequest(new { error = "Title is required" });

            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTask), new { id = task.Id }, task);
        }

        [HttpPut]
        [Route("UpdateTask/{id}")]
        public async Task<IActionResult> UpdateTask(int id, TaskItem updatedTask)
        {
            if (id != updatedTask.Id)
                return BadRequest();

            if (string.IsNullOrWhiteSpace(updatedTask.Title))
                return BadRequest(new { error = "Title is required" });

            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
                return NotFound();

            task.Title = updatedTask.Title;
            task.Description = updatedTask.Description;
            task.DueDate = updatedTask.DueDate;
            task.IsComplete = updatedTask.IsComplete;

            await _context.SaveChangesAsync();
            return Ok(task);
        }

        [HttpDelete]
        [Route("DeleteTask/{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null) return NotFound();

            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Task deleted successfully" });
        }
    }
}
