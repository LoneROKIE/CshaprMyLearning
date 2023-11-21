using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoPizza.Models
{
    public class Product
    {
        //[Key] // la decoramos con esta etiqueta para que se cree como primary key en la base de datos
        public int Id { get; set; }

        //[Required] // la decoramos con esta etiqueta para que se cree como not null en la base de datos
        public string Name { get; set; } = null; // esto es para que por defecto sea null

        [Column(TypeName = "decimal(6,2)")] // esto es para que en la base de datos se cree como decimal(6,2)
        public decimal Price { get; set; }


    }
}
