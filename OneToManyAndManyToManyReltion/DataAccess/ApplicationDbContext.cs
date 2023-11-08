using Microsoft.EntityFrameworkCore;
using OneToManyAndManyToManyReltion.Models;

namespace OneToManyAndManyToManyReltion.DataAccess
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base() { }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
    }
}
