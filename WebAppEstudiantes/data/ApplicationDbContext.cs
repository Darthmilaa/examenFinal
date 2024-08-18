using Microsoft.EntityFrameworkCore;
using WebAppEstudiantes.Models;

namespace WebAppEstudiantes.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
