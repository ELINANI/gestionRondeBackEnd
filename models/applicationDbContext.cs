using Microsoft.EntityFrameworkCore;

namespace gestionRondeBackEnd.models
{
    public class applicationDbContext:DbContext
    {
        public applicationDbContext(DbContextOptions<applicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Admin> Admins {get; set;}
        public DbSet<Planning> Plannings {get; set;}
        public DbSet<Agent> Agents {get; set;}
        public DbSet<BLE> BLEs {get; set;}
        public DbSet<Trace> Traces {get; set;}
    }
}