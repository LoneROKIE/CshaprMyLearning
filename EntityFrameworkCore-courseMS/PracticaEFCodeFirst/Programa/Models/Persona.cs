using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set;}
        public string Apellido2 { get; set; }
        public string Direccion { get; set; }

        [ForeignKey("Trabajo")]
        public int IdTrabajo { get; set; }

        // propiedades de navegacion
        public Trabajo Trabajo { get; set; } = null!;

    }
}
