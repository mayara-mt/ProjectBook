using Microsoft.EntityFrameworkCore;

namespace ProjectBook.Model
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }
    }
}
