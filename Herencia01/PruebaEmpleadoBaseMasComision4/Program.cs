// FIG. 10.15: PruebaEmpleadoBaseMasComision4.cs
// Prueba de la jerarquia de la clase EmpleadoBaseMasComision4
using EPM;
using System;

public class PruebaEmpleadoBaseMasComision4
{
    public static void Main(string[] args)
    {
        // crea instancia de un objeto EmpleadoBaseMasComision4
        EmpleadoBaseMasComision4 empleado = new EmpleadoBaseMasComision4("Bob", "Lewis", "333-33-3333", 5000.00M, .04M, 300.00M);

        // muestra los datos del empleado por comision con salario base
        Console.WriteLine("Informacion del empleado obtenida por las propiedades y metodos: \n");
        Console.WriteLine("{0} {1}", "El primer nombre es", empleado.PrimerNombre);
        Console.WriteLine("{0} {1}", "El apellido paterno es", empleado.ApellidoPaterno);
        Console.WriteLine("{0} {1}", "El numero de seguro social es", empleado.NumeroSeguroSocial);
        Console.WriteLine("{0} {1:C}", "Las ventas brutas son", empleado.VentasBrutas);
        Console.WriteLine("{0} {1:F2}", "La tarifa de comision es", empleado.TarifaComision);
        Console.WriteLine("{0} {1:C}", "El salario base es", empleado.SalarioBase);
        Console.WriteLine("{0} {1:C}", "Los ingresos son", empleado.Ingresos());

        empleado.SalarioBase = 1000.00M; // establece el salario base

        Console.WriteLine("\n{0}:\n\n{1}", "Informacion actualizada del empleado, obtenida mediante ToString", empleado);
        Console.WriteLine("{0} {1:C}", "Los ingresos son", empleado.Ingresos());
    }
}
