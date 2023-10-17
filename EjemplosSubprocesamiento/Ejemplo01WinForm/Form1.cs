namespace Ejemplo01WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // declaracion del hilo
            Thread hilo1;

            // instanciamos el hilo e indica el metodo que se ejecutara en el hilo
            hilo1 = new Thread(new ThreadStart(RealizarTarea));
            // ejecutamos el hilo
            hilo1.Start();
        }

        public static void RealizarTarea()
        {
            // cuando se ejecuta el hilo, se bloquea la interfaz grafica
            // tengo que esperar a que termine el hilo para poder seguir trabajando
            for(int i = 0; i < 30; i++)
            {
                Thread.Sleep(1000);
            }
            MessageBox.Show("El hilo ha finalizado");
        }

    }
}