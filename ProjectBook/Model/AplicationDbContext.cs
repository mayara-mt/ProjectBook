using Microsoft.EntityFrameworkCore;
using ProjectBook.Model;

namespace ProjectBook.Model
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }
        public DbSet<ProjectBook.Model.Book> Book { get; set; }
    }
}
