// clase para probar la clase EmpleadoPorComision
using EPM;

public class PruebaEmpleadoPorComision
{
    public static void Main(string[] args)
    {
        // crea instancia de objeto EmpleadoPorComision
        EmpleadoPorComision empleado = new EmpleadoPorComision("Sue", "Jones",
            "222-22-2222", 10000.00M, .06M); // adjuntamos la M para indicar que es decimal

        // muestra datos del empleado por comision
        Console.WriteLine("Informacion del empleado obtenida por las propiedades y metodos: \n");
        Console.WriteLine("Primer nombre es {0}", empleado.PrimerNombre);
        Console.WriteLine("Apellido paterno es {0}", empleado.ApellidoPaterno);
        Console.WriteLine("Numero de seguro social es {0}", empleado.NumeroSeguroSocial);
        Console.WriteLine("Ventas brutas son {0:C}", empleado.VentasBrutas);
        Console.WriteLine("Tarifa de comision es {0:F2}", empleado.TarifaComision);
        Console.WriteLine("Ingresos son {0:C}", empleado.Ingresos());

        empleado.VentasBrutas = 5000.00M; // Establece las ventas brutas
        empleado.TarifaComision = .1M; // Establece la tarifa de comision

        Console.WriteLine("\n{0}:\n\n{1}", "Informacion actualizada del empleado, obtenida mediante ToString", empleado);
        Console.WriteLine("Ingresos: {0:C}", empleado.Ingresos());
    } // fin de Main
} // fin de la clase PruebaEmpleadoPorComision