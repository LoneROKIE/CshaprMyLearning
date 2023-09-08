using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EPM
{
    public class EmpleadoPorComision : Object
    {

        private string primerNombre;
        private string apellidoPaterno;
        private string numeroSeguroSocial;
        private decimal ventasBrutas; // ventas semanales totales
        private decimal tarifaComision; // procentaje de comision

        // constructor con cinco parametros
        public EmpleadoPorComision(string nombre, string apellido, string nss, decimal ventas, decimal tarifa)
        {
            // la llamada implicita al constructor del objeto ocurre aqui
            primerNombre = nombre;
            apellidoPaterno = apellido;
            numeroSeguroSocial = nss;
            ventasBrutas = ventas; // valida las ventas brutas mediante una propiedad
            tarifaComision = tarifa; // valida la tarifa por comision mediante una propiedad
        } // fin del constructor de EmpleadoPorComision con cinco parametros

        // metodos get y set
        public string PrimerNombre
        {
            get { return primerNombre;}
        }

        public string ApellidoPaterno
        {
            get { return apellidoPaterno;}
        }

        public string NumeroSeguroSocial
        {
            get { return numeroSeguroSocial;}
        }

        public decimal VentasBrutas
        {
            get { return ventasBrutas; }
            set { ventasBrutas = (value < 0) ? 0 : value; }
        }

        public decimal TarifaComision
        {
            get { return tarifaComision; }
            set { tarifaComision = (value > 0 && value < 1) ? value : 0; }
        }
        // METODOS
        // calcula el salario del empleado por comision
        public decimal Ingresos()
        {
            return tarifaComision * ventasBrutas;
        } // fin del metodo Ingresos


        // devuelve representacion string del objeto EmpleadoPorComision
        public override string ToString()
        {
            return string.Format(
            "{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}",
            "empleado por comision", PrimerNombre, ApellidoPaterno,
            "numero de seguro social", NumeroSeguroSocial,
            "ventas brutas", VentasBrutas, "tarifa de comision", TarifaComision);
        } // fin del metodo ToString

    }


}