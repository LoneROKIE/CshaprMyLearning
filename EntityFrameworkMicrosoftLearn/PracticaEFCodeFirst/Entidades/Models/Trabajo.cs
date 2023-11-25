using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Trabajo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set;}
        public string Telefono { get; set; }
        public int idPersona { get; set; }
        public Persona Persona { get; set; }

    }
}
