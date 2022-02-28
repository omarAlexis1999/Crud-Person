using ControlIngresoGasto.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlIngresoGasto.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
    }
}
