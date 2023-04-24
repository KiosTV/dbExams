using Microsoft.EntityFrameworkCore;

namespace dbExams.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
            
        }
    }
}
