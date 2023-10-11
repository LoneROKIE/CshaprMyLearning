using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaModificarObjEnArrayEnDataGrid
{
    public class Cliente
    {
        public string Nombre;
        public string NumeroId;
        public char Estado;

        // arreglo de clientes
        public static Cliente[] clientes = new Cliente[10];

        public Cliente(string nombre,string numeroId,char estado)
        {
            this.Nombre = nombre;
            this.NumeroId = numeroId;
            this.Estado = estado;
        }

        // getters y setters
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string numeroId
        {
            get { return NumeroId; }
            set { NumeroId = value; }
        }
        public char estado
        {
            get { return Estado; }
            set { Estado = value; }
        }

    }
}
