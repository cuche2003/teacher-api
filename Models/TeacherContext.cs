using Microsoft.EntityFrameworkCore;

namespace TeacherAPI.Models
{
    public class TeacherContext : DbContext
    {
        public TeacherContext(DbContextOptions<TeacherContext> options)
        : base(options)
        {
        }

        public DbSet<Teacher> Teachers { get; set; } = null!;
    }
}
