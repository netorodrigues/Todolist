using FluentValidation;

namespace Api.Requests
{
    public class TaskCreateRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? ScheduledDate { get; set; }
    }

    public class TaskCreateRequestValidator : AbstractValidator<TaskCreateRequest>
    {
        public TaskCreateRequestValidator()
        {
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
        }
    }
}
