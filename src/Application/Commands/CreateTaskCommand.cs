﻿using Application.Seedwork.Command;

namespace Application.Commands
{
    public class CreateTaskCommand : Command
    {
        public CreateTaskCommand(string title, string description, DateTime? scheduledDate)
        {
            Title = title;
            Description = description;
            ScheduledDate = scheduledDate;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? ScheduledDate { get; set; }
    }
}