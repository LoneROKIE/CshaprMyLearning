using InterfacesPractica2;

public class Principal
{
    public static void Main(string[] args)
    {
        // probando la clase rectangulo
        Rectangulo rectangulo = new Rectangulo(10,20);
        
        rectangulo.calcPerimetro();
        rectangulo.calcArea();

        // probando la clase cuadrado
        Cuadrado cuadrado = new Cuadrado(10);

        cuadrado.calcPerimetro();
        cuadrado.calcArea();

    }
}