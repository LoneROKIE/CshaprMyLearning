namespace ContosoPizza.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; } // esto es para que se cree como foreign key en la base de datos
        public int OrderId { get; set; } // esto es para que se cree como foreign key en la base de datos
        public Order Order { get; set; } = null!;
        public Product Product { get; set; } = null!;



    }
}