using Examen_DAW.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace Examen_DAW.Server.Data
{
    public class DatabaseContext: DbContext
    {
        public DbSet<Test> Tests { get; set; }
        public DbSet<Materie> Materii {  get; set; }
        public DbSet<Profesor> Profesori {  get; set; }

        public DbSet<ProfesorMaterie> ProfesorMaterie { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            
            modelBuilder.Entity<ProfesorMaterie>().HasKey(pm => new { pm.ProfesorId, pm.MaterieId });

            modelBuilder.Entity<ProfesorMaterie>()
                .HasOne(pm => pm.Profesor)
                .WithMany(p => p.ProfesoriMaterii)
                .HasForeignKey(pm => pm.ProfesorId);

            modelBuilder.Entity<ProfesorMaterie>()
                .HasOne(pm => pm.Materie)
                .WithMany(m => m.ProfesorMaterii)
                .HasForeignKey(pm => pm.MaterieId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
