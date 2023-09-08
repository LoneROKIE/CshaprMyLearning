// Prueba de la clase EmpleadoBaseMasComision
using EPM;
using System;

public class PruebaEmpleadoBaseMasComision
{
    public static void Main(string[] args)
    {
        // crea instancia de objeto EmpleadoBaseMasComision
        EmpleadoBaseMasComision empleado = new EmpleadoBaseMasComision("Bob", "Lewis",
                       "333-33-3333", 5000.00M, .04M, 300.00M); // adjuntamos la M para indicar que es decimal

        // muestra en pantalla los datos del empleado por comision con salario base
        Console.WriteLine("Informacion del empleado obtenida por las propiedades y metodos: \n");
        Console.WriteLine("Primer nombre es {0}", empleado.PrimerNombre);
        Console.WriteLine("Apellido paterno es {0}", empleado.ApellidoPaterno);
        Console.WriteLine("Numero de seguro social es {0}", empleado.NumeroSeguroSocial);
        Console.WriteLine("Ventas brutas son {0:C}", empleado.VentasBrutas);
        Console.WriteLine("Tarifa de comision es {0:F2}", empleado.TarifaComision);
        Console.WriteLine("Salario base es {0:C}", empleado.SalarioBase);
        Console.WriteLine("Ingresos son {0:C}", empleado.Ingresos());

        empleado.SalarioBase = 1000.00M; // establece el salario base
        Console.WriteLine("\n{0}:\n\n{1}", "Informacion actualizada del empleado, obtenida mediante ToString", empleado);
        
        Console.WriteLine("Ingresos: {0:C}", empleado.Ingresos());


    }
}
