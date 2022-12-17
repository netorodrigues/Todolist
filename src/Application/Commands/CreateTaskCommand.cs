﻿using Application.Seedwork.Command;

namespace Application.Commands
{
    public class CreateTaskCommand : Command
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? ScheduledDate { get; set; }
    }
}