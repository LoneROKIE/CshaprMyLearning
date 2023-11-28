using Entidades.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Data
{
    public class PracticeContext : DbContext
    {
        public DbSet<Persona> personas { get; set; } = null!;
        public DbSet<Trabajo> trabajos { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>()
                .HasOne(p => p.Trabajo)  // Establecer la relación uno a uno desde Persona a Trabajo
                .WithOne(t => t.Persona) // Establecer la relación inversa desde Trabajo a Persona
                .HasForeignKey<Persona>(p => p.IdTrabajo); // Especificar la clave foránea en Persona
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =DuncanPC; Initial Catalog = PersonaYTrabajo; Integrated Security = True; TrustServerCertificate=True");
        }
    }
}
