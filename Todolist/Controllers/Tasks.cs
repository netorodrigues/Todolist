using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Todolist.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Tasks : ControllerBase
    {

        private readonly ILogger<Tasks> _logger;

        public Tasks(ILogger<Tasks> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public List<Task> Get()
        {
            return new List<Task>();
        }
    }
}