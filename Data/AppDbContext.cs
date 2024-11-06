using Libreria.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace Libreria.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
