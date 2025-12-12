using CrudNet8MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudNet8MVC.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }
 
        //Modelos de las tablas de la base de datos
        public DbSet<Contacto> Contacto { get; set; }

    }
}
