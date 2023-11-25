using ContosoPizza.Data;
using ContosoPizza.Models;

using ContosoPizzaContext context = new ContosoPizzaContext(); // Creamos una instancia de la clase ContosoPizzaContext

/*
Product veggieSpecial = new Product()
{
    Name = "Veggie Special Pizza",
    Price = 9.99M
};
context.Add(veggieSpecial); // Añadimos el objeto veggieSpecial a la tabla Products

Product deluxeMeat = new Product()
{
    Name = "Deluxe Meat Pizza",
    Price = 12.99M
};

context.Add(deluxeMeat);
context.SaveChanges(); // Guarda los cambios en la base de datos
*/


// Esto es fluent API sintaxis

// var products = context.Products; // Obtenemos todos los productos de la tabla Products
var products = context.Products.Where(p => p.Price > 10.00M).OrderBy(p => p.Name);

// si no nos gusta la sintaxis de fluent API podemos usar LINQ
// var products = from p in context.Products
//                where p.Price > 10.00M
//                orderby p.Name
//                select p;

foreach(Product p in products)
{
    Console.WriteLine($"Id:     {p.Id}");
    Console.WriteLine($"Name:     {p.Name}");
    Console.WriteLine($"Price:     {p.Price}");
    Console.WriteLine(new string('-', 20));
}

// para borrar un producto
// var product = context.Products.Find(1); // Buscamos el producto con id 1
// context.Remove(product); // Borramos el producto