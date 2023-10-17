namespace Ejemplo05SincronizacionGUI
{
    public partial class Form1 : Form
    {
        // Declaracion de Metodo delegado
        private delegate void CambiarBarraDeProgresoDelegado(int valorPorcentaje);
        private delegate void CambiarPropiedadesBotonDelegado();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            button1.Enabled = false;
            button1.BackColor = Color.LightPink;
            button1.Text = "Procesando...";

            //EjecutarProceso();
            CrearHilo();
        }

        private void EjecutarProceso()
        {
            for(int i = 0; i < 100; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(100);
            }
            button1.Enabled = true;
            button1.BackColor = Color.LightGreen;
            button1.Text = "Iniciar";
        }

        private void CrearHilo()
        {
            Thread hilo1; 
            hilo1= new Thread(new ThreadStart(EjecutarProcesoConInvoke));
            hilo1.Start();
        }

        private void EjecutarProcesoConInvoke()
        {
            for(int i = 0; i <= 100; i++)
            {
                // Ejecuta Invoke para ejecutar el metodo de CambiarBarraDeProgreso
                Invoke(new CambiarBarraDeProgresoDelegado(CambiarBarraDeProgreso), new object[] { i });
                Thread.Sleep(100);
            }
            Invoke(new CambiarPropiedadesBotonDelegado(CambiarPropiedadesBoton));
        }

        // metodo que cambia la propiedade value de un contron de barra de progreso
        private void CambiarBarraDeProgreso(int valor)
        {
            progressBar1.Value = valor;
        }

        // metodo que cambia la propiedad la propiedad value de un control de barra de progreso
        private void CambiarPropiedadesBoton()
        {
            button1.Enabled = true;
            button1.BackColor = Color.LightGreen;
            button1.Text = "Iniciar";
        }
    }
}