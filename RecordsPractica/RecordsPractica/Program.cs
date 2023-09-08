using System;

/*
 * Los records son un tipo de dato que se introdujo en C# 9.0, y que nos permite crear objetos inmutables
 * estos sirven para crear objetos que no van a cambiar, y que por tanto, no necesitan de un constructor
 * ademas de que nos permite crearlos de una forma mas sencilla.
 * 
 * Es recomendable usarlos cuando se necesite crear objetos que no van a cambiar
 * 
 * 
 */

public class Principal
{
    public static void Main(string[] args)
    {
        IceCream icecream = new IceCream("Chocolate", "cafe");
        Console.WriteLine(icecream);

        NuttyIceCream nuttyIceCream = new NuttyIceCream("Pistachio","Green","Pistachio");
        Console.WriteLine(nuttyIceCream);

       VeganIceCream veganIceCream = new VeganIceCream("Pistachio", "Blue", "Pistachio", 
           new string[] {"Coconut milk","blood of flowers lol"});
        Console.WriteLine(veganIceCream);

        // cambiamos el sabor de IceCream usando with
        var heladoConAnteriorSabor  =CambiaSabor(icecream, "Limon con menta");
        Console.WriteLine("COPIA ORIGINAL:" + icecream);
        Console.WriteLine("COPIA CON NUEVO SABOR: " + heladoConAnteriorSabor);

        // otra forma de usar with
        IceCream helado1 = new IceCream("Coco", "blanco");
        IceCream helado2 = helado1 with { Flavor = "Vainilla" };
        Console.WriteLine(helado1); // copia original helado1
        Console.WriteLine(helado2); // copia de helado1 con datos modificados.

        Rectangle rectangulo1 = new Rectangle(202,198);
        Console.WriteLine(rectangulo1);
        rectangulo1.Width = 2034;
        Console.WriteLine(rectangulo1);
    }
    // record normal
    public record  IceCream(string Flavor, string Color);

    // record que hereda de otro
    public record NuttyIceCream(string Flavor, string Color, string seedType)
        : IceCream(Flavor,Color);

    // otro record que hereda de nutty Ice cream
    public record VeganIceCream(string Flavor, string Color, string SeedType, string[] Ingredients)
        : IceCream(Flavor, Color);

    // metodo para cambiar el sabor de un helado normal, aunque en si lo que hace es devolver una copia
    // con el cambio hecho
    public static IceCream CambiaSabor(IceCream iceCream, string nuevoSabor)
    {
        return iceCream with { Flavor = nuevoSabor };
    }

    // miembros adicionales con record
    public record Rectangle(float Width, float Heigth)
    {
        // creamos la propiedad Area multiplicando Width con Heigth
        public float Area => Width * Heigth;
        // creamos propiedades mutables a uno de los atributos del record
        public float Width { get; set; } = Width;
    }

}

