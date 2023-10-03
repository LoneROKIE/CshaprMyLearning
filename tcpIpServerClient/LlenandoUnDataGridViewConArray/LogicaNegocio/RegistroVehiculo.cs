using Entidades;
using System.Windows.Forms;

namespace LogicaNegocio
{
    public class RegistroVehiculo
    {
        public static void RegistrarVehiculo(string Tipo, string NombreV, string Color, DataGridView gridview )
        {
            // creamos el objeto tipo vehiculo
            Vehiculo nuevoVehiculo = new Vehiculo(Tipo, NombreV, Color);
            // guardamos el vehiculo en el arreglo static 
            try
            {
                for (int i = 0; i < Vehiculo.ArrVehiculo.Length; i++)
                {
                    if (Vehiculo.ArrVehiculo[i] == null)
                    {
                        Vehiculo.ArrVehiculo[i] = nuevoVehiculo;
                       // MessageBox.Show("Nuevo Vehiculo Aniadido!!!");
                        break;
                    }
                }

                gridview.DataSource = Vehiculo.ArrVehiculo;
              
            }
            catch(Exception e)
            {
                MessageBox.Show("Hubo un error: {0}",e.ToString());
               
            }


        }
    }
}