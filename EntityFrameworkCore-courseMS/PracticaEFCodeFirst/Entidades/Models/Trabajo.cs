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
        public int IdTrabajo { get; set; }
        public string NombreTrabajo { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        [Key, ForeignKey("Persona")]
        public int IdPersona { get; set; }
        
        

    }
}
