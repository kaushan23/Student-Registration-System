using Microsoft.EntityFrameworkCore;
using WebApplication1.Models; // Replace with your namespace


namespace WebApplication1.Data // Replace with your namespace
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Add DbSet properties for your models
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}