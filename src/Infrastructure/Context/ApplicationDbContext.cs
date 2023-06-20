using Microsoft.EntityFrameworkCore;
using Task = Domain.Entities.TaskAgg.Task;

namespace Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

    }
}
