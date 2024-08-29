using Microsoft.EntityFrameworkCore;
using EnrollmentSystem.Models.Entities;

namespace EnrollmentSystem.Web.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
