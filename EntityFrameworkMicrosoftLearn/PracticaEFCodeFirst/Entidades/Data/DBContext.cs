using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Data
{
    public class DBContext : DbContext
    {
        public DbSet<Models.Trabajo> Trabajos { get; set; }
        public DbSet<Models.Persona> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =DuncanPC; Initial Catalog = PersonaTrabajo; Integrated Security = True; TrustServerCertificate=True");
        }

    }
}
