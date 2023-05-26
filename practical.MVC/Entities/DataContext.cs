using Microsoft.EntityFrameworkCore;
namespace practical.MVC.Entities
{
    public class DataContext : DbContext
    {
        public DbSet<Exam> Exam { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
