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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =DuncanPC; Initial Catalog = PersonaYTrabajo; Integrated Security = True; TrustServerCertificate=True");
        }

    }
}
