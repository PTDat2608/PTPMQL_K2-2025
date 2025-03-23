using FirstWebMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FirstWebMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        
        public DbSet<Employee> Employee { get; set; } = default!;
        public DbSet<Student> Student { get; set; } = default!;
        public DbSet<DaiLy> DaiLy { get; set; } = default!;
        public DbSet<HeThongPhanPhoi> HeThongPhanPhoi { get; set; } = default!;
        public DbSet<Person> Person { get; set; } = default!;
         
    }
}