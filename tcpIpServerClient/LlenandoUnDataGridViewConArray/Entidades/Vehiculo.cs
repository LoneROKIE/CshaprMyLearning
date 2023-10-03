namespace Entidades
{
    public class Vehiculo
    {
        #region Atributos clase
        private string Tipo;
        private string NombreV;
        private string Color;
        #endregion

        // arreglo estatico 20 posiciones para almacenar vehiculos
        public static Vehiculo[] ArrVehiculo = new Vehiculo[20];

        #region constructores
        public Vehiculo(string Tipo, string NombreV, string Color)
        {
            this.Tipo = Tipo;
            this.NombreV = NombreV;
            this.Color = Color;
        }
        #endregion

        #region getters y setters
        public string tipo
        {
            get{ return  Tipo; }
            set { Tipo = value; }
        }
        public string nombreV
        {
            get { return NombreV; }
            set { NombreV = value; }
        }
        public string color
        {
            get { return Color; }
            set { Color = value; }
        }
        #endregion

    }
}