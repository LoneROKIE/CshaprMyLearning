using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaModificarObjEnArrayEnDataGrid
{
    public partial class RegistrarCli : Form
    {
        public RegistrarCli(Cliente cliente)
        {
            InitializeComponent();
            textBox1.Text = cliente.NumeroId;
            textBox2.Text = cliente.Nombre;
            if (cliente.Estado == 'A')
            {
                comboBox1.SelectedItem = "Activo";
            }
            else
            {
                comboBox1.SelectedItem = "Inactivo";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // modificamos el estado del cliente y lo sustituimos en el array
            char estado = ' ';
            if (comboBox1.SelectedItem == "Activo")
            {
                estado = 'A';
            }
            else
            {
                estado = 'I';
            }

            Cliente cliente = new Cliente(textBox2.Text, textBox1.Text, estado);

            modificarEstadoCliente(cliente);

            // mostramos el Form1
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();


        }

        // metodo para modificar el estado de un cliente
        public void modificarEstadoCliente(Cliente cliente)
        {
            for (int i = 0; i < Cliente.clientes.Length; i++)
            {
                if (Cliente.clientes[i].numeroId == cliente.numeroId)
                {
                    Cliente.clientes[i].estado = cliente.estado;
                    break;
                }
            }

        }

    }
}
