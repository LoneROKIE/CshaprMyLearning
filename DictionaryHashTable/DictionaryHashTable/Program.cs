class Principal
{
    public static void Main(string[] args)
    {
        // dictionary
        // var d = new Dictionary<key, value>();
        var d = new Dictionary<string, int>();

        // agregamos un valor al diccionario
        d.Add("One", 1);
        d["Two"] = 2; // se aniade porque no existe en el dicc.
        d["Two"] = 22; // se actualiza porque existe en el dicc.
        d["Three"] = 3;

        Console.WriteLine(d["Two"]);
        Console.WriteLine(d["Three"]);
    }
}
