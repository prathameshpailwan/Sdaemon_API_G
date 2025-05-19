using Microsoft.EntityFrameworkCore;
using Sdaemon.Model;
using System.Collections.Generic;

namespace Sdaemon.DAL
{
    // Data/TaskDbContext.cs
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) { }
        public DbSet<TaskItem> Tasks { get; set; }
    }

}
