using GestionEventosAcademicos.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestionEventosAcademicos.API.Data
{
    public class DataContext:DbContext
    {
        //Inyeccion de dependencias

        public DataContext(DbContextOptions<DataContext>options):base(options)
        {
            
        }

        public DbSet<Event> Events {  get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<GestionEventosAcademicos.Shared.Entities.Program> Programs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
    
}
