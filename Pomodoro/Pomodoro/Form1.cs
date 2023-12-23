namespace Pomodoro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // creamos un timer de 50 minutos que es el tiempo de trabajo
            int WorkMinutes = 50;
            int WorkSeconds = 1;
            // creamos un timer de 10 minutos que es el tiempo de descanso
            int breakTime = 10;
            int breakSeconds = 0;
       
            while(WorkMinutes > 0)
            {
                WorkMinutes--;
                // mostramos el tiempo de trabajo en el label
                labelhoras.Text = WorkMinutes.ToString();
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Start the timer
            
            Thread hilo = new Thread(new ThreadStart(timer1.Start));
            hilo.Start();


        }
    }
}
