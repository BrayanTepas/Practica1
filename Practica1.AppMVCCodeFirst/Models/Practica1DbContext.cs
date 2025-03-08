using Microsoft.EntityFrameworkCore;
namespace Practica1.AppMVCCodeFirst.Models
{
    public class Practica1DbContext : DbContext
    {
        public Practica1DbContext(DbContextOptions<Practica1DbContext> options) : base(options) { }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
    }
}
