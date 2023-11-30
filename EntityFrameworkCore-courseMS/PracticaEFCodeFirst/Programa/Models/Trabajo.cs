using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Trabajo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTrabajo { get; set; }
        public string NombreTrabajo { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        // propiedades de navegacion
        public Persona Persona { get; set; } = null!;

        // lista de trabajos
        public List<Trabajo> trabajos { get; } = new();
        

    }
}
