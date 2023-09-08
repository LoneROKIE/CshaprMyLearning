using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPM
{
    public class EmpleadoBaseMasComision2 : EmpleadoPorComision2 // hereda de EmpleadoPorComision
    {
        private decimal salarioBase; // salario base por semana

        // constructor de la clase derivada con seis parametros
        // con una llamada al constructor de la clase base EmpleadoPorComision
        public EmpleadoBaseMasComision2(string nombre,string apellido, string nss, decimal ventas, decimal tarifa
            ,decimal salario) : base(nombre, apellido, nss, ventas, tarifa) // llama al constructor base
        {
            salarioBase = salario; // valida el salario base mediante una propiedad
        } // fin del constructor de EmpleadoBaseMasComision2


        // propiedad que obtiene y establece el salario base del empleado por comision con salario base
        public decimal SalarioBase
        {
            get { return salarioBase; }
            set { salarioBase = (value < 0) ? 0 : value; }
        }

        // calcula los ingresos
        public override decimal Ingresos()
        {
            // no se permite: TarifaComision y VentasBrutas son privados en la clase base
            return SalarioBase + (TarifaComision * VentasBrutas);
        } // fin del metodo Ingresos

        // devuelve representacion string de un objeto EmpleadoBaseMasComision2
        public override string ToString()
        {
            // no se permite: intenta acceder a los miembros privados de la clase base
            return string.Format(
                "{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}\n{9}: {10:C}", "empleado por comisión con salario base",
                primerNombre, apellidoPaterno, "número de seguro social", numeroSeguroSocial,
                "ventas brutas", ventasBrutas, "tarifa de comisión", tarifaComision,
                "salario base", salarioBase);
        }


    }
}
