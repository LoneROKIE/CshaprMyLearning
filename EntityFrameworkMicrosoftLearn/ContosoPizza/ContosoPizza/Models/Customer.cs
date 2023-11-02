using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoPizza.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; } = null!; // esto se hace para que no de error de que no se ha inicializado
         
        public string LastName { get; set; } = null!; // esto se hace para que no de error de que no se ha inicializado

        public string? Phone { get; set; } // el ? es para que pueda ser null

        public ICollection<Order> Oders { get; set; } = null; // esto se hace para que no de error de que no se ha inicializado

        // quede en el primer video minuto 4:21
    }
}
