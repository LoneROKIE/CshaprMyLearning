namespace PracticaModificarObjEnArrayEnDataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = Cliente.clientes;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string numeroId = textBox2.Text;
            char estado = ' ';

            if (comboBox1.SelectedItem == "Activo")
            {
                estado = 'A';
            }
            else
            {
                estado = 'I';
            }

            // creamos el objeto
            Cliente cliente = new Cliente(nombre, numeroId, estado);

            agregarCliente(cliente);

        }

        // metodo para agregar un cliente al array
        public void agregarCliente(Cliente cliente)
        {
            for (int i = 0; i < Cliente.clientes.Length; i++)
            {
                if (Cliente.clientes[i] == null)
                {
                    Cliente.clientes[i] = cliente;
                    break;
                }
            }

            // mostramos el array en el datagrid
            dataGridView1.DataSource = Cliente.clientes;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // seleccionamos el cliente a modificar del datagrid
            Cliente cliente = (Cliente)dataGridView1.CurrentRow.DataBoundItem;
            // lo enviamos al formulario de modificacion
            RegistrarCli clie = new RegistrarCli(cliente);
            clie.Show();

            this.Hide();
        }
    }
}