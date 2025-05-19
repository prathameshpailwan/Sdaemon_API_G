﻿using System.ComponentModel.DataAnnotations;

namespace Sdaemon.Model
{
    public class TaskItem
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public bool IsComplete { get; set; }
    }
}
