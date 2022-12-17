using Api.Mappers;
using Api.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Todolist.API.Controllers
{
    [ApiController]
    [Route("/tasks")]
    public class TaskController : ControllerBase
    {

        private readonly IMediator _mediator;

        public TaskController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTask([FromBody] TaskCreateRequest request, CancellationToken cancellationToken)
        {
            var createTaskCommand = request.ToCommand();
            var response = await _mediator.Send(createTaskCommand, cancellationToken);
            
            return Ok(response);
        }
    }
}