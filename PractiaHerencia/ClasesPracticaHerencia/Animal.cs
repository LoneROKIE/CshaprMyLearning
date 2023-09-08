namespace ClasesPracticaHerencia
{
    public abstract class Animal // si esta clase es abstracta no se puede instanciar, solo se puede heredar
    {
        private string tipoAnimal { get; set; }
        private string nombre { get; set; }

        public Animal(string tipoAnimal, string nombre)
        {
            this.tipoAnimal = tipoAnimal;
            this.nombre = nombre;
        }

        public virtual void Sonido(String sonido) // lo declaro virtual para que pueda ser sobreescrito en las clases hijas
        {
            System.Console.WriteLine("El animal hace un sonido");
        }

        public abstract bool EsDomestico(string resp); // lo declaro abstracto para que sea obligatorio implementarlo en las clases hijas


        // toString
        public override string ToString()
        {
            return $"El animal es del tipo: {tipoAnimal} y su nombre es: {nombre}";
        }





    }
}