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
        public string FirstName { get; set; } = null!; // null! es para que no de error de que puede ser null
        public string LastName { get; set; } = null!;
        public string? Address { get; set; }
        public string? Phone { get; set; }
        // ICollection es una interfaz que nos permite crear una lista de objetos para poder acceder a ellos
        public ICollection<Order> Orders { get; set; } = null!;
    }
}
