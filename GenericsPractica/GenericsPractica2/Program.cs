// usando diccionarios, ya que estos son parte de generics

public class Principal
{
    public static void Main(string[] args)
    {
        // creamos el diccionario
        Dictionary<int, string> diccCedsNombre = new Dictionary<int, string>();

        // aniadimos un valor al diccionario
        diccCedsNombre.Add(93209231, "Oscar de la Flor");
        diccCedsNombre.Add(3123123, "Casimiro Robles");

        // ups parece que alguien aniadio un nombre que no deberia estar en el dicc
        diccCedsNombre.Add(1111, "Rosa DASO");
        // entonces hay que borrarlo
        diccCedsNombre.Remove(1111);

        // asi se imprime un diccionario
        foreach(KeyValuePair<int, string> entry in diccCedsNombre )
        {
            Console.WriteLine(entry.Key + " : "+ entry.Value);
        }
        

    }



}



