using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPM
{
    public class EmpleadoPorComision4
    {
        private string primerNombre;
        private string apellidoPaterno;
        private string numeroSeguroSocial;
        private decimal ventasBrutas;
        private decimal tarifaComision;

        // constructor con cinco argumentos
        public EmpleadoPorComision4(string nombre, string apellido, string nss, decimal ventas, decimal tarifa)
        {
            // la llamada implicita al constructor de object ocurre aqui
            primerNombre = nombre;
            apellidoPaterno = apellido;
            numeroSeguroSocial = nss;
            ventasBrutas = ventas; // valida las ventas brutas a traves de una propiedad
            tarifaComision = tarifa; // valida la tarifa de comision a traves de una propiedad

            Console.WriteLine("\nConstructor de EmpleadoPorComision4:\n" + this);
        }

        // propiedad de solo lectura que obtiene el primer nombre del empleado por comision
        public string PrimerNombre
        {
            get
            {
                return primerNombre;
            }
        }

        // propiedad de solo lectura que obtiene el apellido paterno del empleado por comision
        public string ApellidoPaterno
        {
            get
            {
                return apellidoPaterno;
            }
        }


        // propiedad de solo lectura que obtiene el numero de seguro social del empleado por comision
        public string NumeroSeguroSocial
        {
            get
            {
                return numeroSeguroSocial;
            }
        }

        // propiedad que obtiene y establece las ventas brutas del empleado por comision
        public decimal VentasBrutas
        {
            get
            {
                return ventasBrutas;
            }
            set
            {
               ventasBrutas = (value < 0) ? 0 : value;
            }
        }   

        // propiedad que obtiene y establece la tarifa de comision del empleado por comision
        public decimal TarifaComision
        {
            get
            {
                return tarifaComision;
            }
            set
            {
                tarifaComision = (value > 0 && value < 1) ? value : 0;
            }
        }


        // calcula el salario del empleado por comision
        public virtual decimal Ingresos()
        {
            return tarifaComision * ventasBrutas;
        }

        // devuelve representacion string del objeto EmpleadoPorComision4
        public override string ToString()
        {
            return string.Format("{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}", "empleado por comision", 
                primerNombre, apellidoPaterno, "numero de seguro social", numeroSeguroSocial, "ventas brutas",
                ventasBrutas, "tarifa de comision", tarifaComision);
        }

    }
}
