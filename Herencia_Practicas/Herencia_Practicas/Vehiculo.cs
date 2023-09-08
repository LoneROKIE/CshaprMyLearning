namespace Herencia_Practicas
{
    public class Vehiculo
    {
        private string Marca;
        private string Modelo;

        // Constructor
        public Vehiculo(string marca, string modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;
        }

        // metodo toString
        public override string ToString()
        {
            return "Marca: " + this.Marca + " // Modelo: " + this.Modelo;
        }

    }
}