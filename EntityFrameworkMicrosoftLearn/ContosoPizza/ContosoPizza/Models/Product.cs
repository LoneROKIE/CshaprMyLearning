using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema; // esto es para que se pueda usar el Column y ponerle el tipo de dato
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoPizza.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!; // esto se hace para que no de error de que no se ha inicializado

        [Column(TypeName = "decimal(6,2)")] // esto es para que en la base de datos se cree como decimal(6,2)
        public decimal Price { get; set; }
    }
}
