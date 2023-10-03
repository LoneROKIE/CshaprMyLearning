using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
namespace Presentacion
{
    public partial class Principal1 : Form
    {
        public Principal1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // obtenemos lo valores de los textbox
            string tipo = textBoxTipo.Text;
            string nombreV = textBoxNombreV.Text;
            string color = textBoxColor.Text;

            RegistroVehiculo.RegistrarVehiculo(tipo, nombreV, color, dataGridView1);

            dataGridView1.Refresh();
        }


    }
}
